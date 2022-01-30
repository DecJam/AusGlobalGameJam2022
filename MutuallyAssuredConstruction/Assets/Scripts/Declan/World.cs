using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GridType
{
	Air,
	Building,
	Tree,
	SmallTree,
	Rubble,
	GardenBox,
    Bush
}

public class World : MonoBehaviour
{
	public GameObject TopHalf;
	public GameObject BottomHalf;

	public GameObject TopRotPoint;
	public GameObject BottumRotPoint;

	public Transform cart;

	private float m_TopRotation;
	private float m_BottomRotation;
	[SerializeField] private float m_RotatationSpeed;

	[SerializeField] private float m_TIckInterval;
	private int m_BackgroundWidth = 24;
	private int m_BackgroundHeight = 8;
	[SerializeField] private GridNode[,] m_GameGrid;
	[SerializeField] private float fudgeOffset;

	private float m_Timer;
	private void Start()
	{
		m_GameGrid = new GridNode[m_BackgroundWidth, m_BackgroundHeight];

		for (int y = 0; y < TopHalf.transform.childCount; y++)
		{
			Transform obj = TopHalf.transform.GetChild(y);

			for (int x = 0; x < obj.childCount; x++)
			{
				Transform child = obj.GetChild(x);
				m_GameGrid[x, y] = child.GetComponentInChildren<GridNode>();
				if (y == 0)
				{
					m_GameGrid[x, y].BlockType = GridType.Building;
				}
				else
				{
					m_GameGrid[x, y].BlockType = GridType.Air;
				}
			}
		}

		for (int y = 0; y < BottomHalf.transform.childCount; y++)
		{
			Transform obj = BottomHalf.transform.GetChild(y);

			for (int x = 0; x < obj.childCount; x++)
			{
				Transform child = obj.GetChild(x);
				m_GameGrid[x, y + TopHalf.transform.childCount] = child.GetComponentInChildren<GridNode>();
				if (y == 0)
				{
					m_GameGrid[x, y + TopHalf.transform.childCount].BlockType = GridType.Building;
				}
				else
				{
					m_GameGrid[x, y + TopHalf.transform.childCount].BlockType = GridType.Air;
				}
			}
		}


		for (int x = 0; x < m_BackgroundWidth; x++)
		{
			for (int y = 0; y < m_BackgroundHeight; y++)
			{
				m_GameGrid[x, y].RefreshBlockType();
			}
		}
	}

	private void Update()
	{
		m_Timer += Time.deltaTime;
		if (m_Timer >= m_TIckInterval)
		{
			Tick();
			m_Timer = 0;
		}
	}

	private void Tick()
	{
		//for all nodes that grow Add a tick, 
	}

	public void Rotate(Vector2 rot)
	{
		m_TopRotation += m_RotatationSpeed * rot.x * Time.deltaTime;
		TopRotPoint.transform.eulerAngles = new Vector3(0, m_TopRotation, 0);

		m_BottomRotation += m_RotatationSpeed * rot.y * Time.deltaTime;
		BottumRotPoint.transform.eulerAngles = new Vector3(0, m_BottomRotation, 0);
	}

	// Gets the cart position from -1 being full left 0 being middle and 1 being full right
	public float GetCartPos()
	{
		//Remap to different range
		//remappedValue = min2 + (value - min1) * (max2 - min2) / (max1 - min1)
		// 10 is a temp value for the rightmost position when 0 is the middle
		return cart.position.x / 10;
	}

	public int FindLowestEmptyAt(int column, bool top)
	{
		int result = 0;
		GridNode node;
		int index = 0;
		if (top)
		{
			node = m_GameGrid[column, index];
			for (index = 0;  node.BlockType != GridType.Air; index ++)
			{
				node = m_GameGrid[column, index];
			}
			result = index;
		}

		else
		{
			index = TopHalf.transform.childCount;
			node = m_GameGrid[column, index];
			for (index = TopHalf.transform.childCount; node.BlockType != GridType.Air; index++)
			{
				node = m_GameGrid[column, index];
			}
			result = index;
		}

		return result - 1;
	}

	public int CalculateCollumn(bool up)
	{
		float cylinderRotation;// get cylinder rotation from 0

		if (up)
		{
			cylinderRotation = TopRotPoint.transform.eulerAngles.y;
		}

		else
		{
			cylinderRotation = BottumRotPoint.transform.eulerAngles.y;
		}

		float section = (360 - cylinderRotation) / 15f; // 15 is # of * between each column
		float playerOffSet = cart.position.x;
		if (playerOffSet > 5) playerOffSet = 5f;
		else if (playerOffSet < -5) playerOffSet = -5f;

		section += playerOffSet * -1;
		section += fudgeOffset; //off set of spindle rotation

		Debug.Log("Section Collumn = " + (int)section%24);
		return (int)section % 24;
	}

	public GridType RemoveBlock(int column, int row, bool top)
	{
		GridType block = GridType.Air;

		if (top)
		{
			block = m_GameGrid[column, row].BlockType;
			m_GameGrid[column, row].BlockType = GridType.Air;

			m_GameGrid[column, row].RefreshBlockType();
		}

		else
		{
			block = m_GameGrid[column, row + TopHalf.transform.childCount].BlockType;
			m_GameGrid[column, row + TopHalf.transform.childCount].BlockType = GridType.Air;

			m_GameGrid[column, row + TopHalf.transform.childCount].RefreshBlockType();
		}
		Debug.Log("Removing: " + block + "At:" + column + " * " + row);
		return block;
	}

	public GridType BlockAt(int column, bool top)
	{
		GridType block = GridType.Air;

		if (top)
		{
			if (column < 0)
			{
				column = m_BackgroundWidth - column;
			}

			block = m_GameGrid[column, 0].BlockType;
		}

		else
		{
			if (column < 0)
			{
				column = m_BackgroundWidth - column;
			}

			block = m_GameGrid[column, 0 + TopHalf.transform.childCount].BlockType;
		}

		return block;
	}

	public void PlaceBlock(int column, int row, bool top, GridType type)
	{ 
		if (top)
		{
			if (column < 0)
			{
				column = m_BackgroundWidth - column;
			}

			m_GameGrid[column, row].BlockType = type;

			m_GameGrid[column, row].RefreshBlockType();
		}

		else
		{
			if (column < 0)
			{
				column = m_BackgroundWidth - column;
			}

			m_GameGrid[column, row + TopHalf.transform.childCount].BlockType = type;

			m_GameGrid[column, row + TopHalf.transform.childCount].RefreshBlockType();
		}

		Debug.Log("Placed:" + type + " At: " + column + " * " + row);
	}
}

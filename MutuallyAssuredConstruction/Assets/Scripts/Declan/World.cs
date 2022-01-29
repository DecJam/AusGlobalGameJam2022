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
	GardenBox
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
	[SerializeField] private GridType[,] m_GameGrid;

	private float m_Timer;
	private void Start()
	{
		m_GameGrid = new GridType[m_BackgroundWidth, m_BackgroundHeight];

		for (int y = 0; y < TopHalf.transform.childCount; y++)
		{
			Transform obj = TopHalf.transform.GetChild(y);

			for (int x = 0; x < obj.childCount; x++)
			{
				Transform child = obj.GetChild(x);
				m_GameGrid[x, y] = child.GetComponentInChildren<GridNode>().BlockType;
			}
		}

		for (int y = 0; y < BottomHalf.transform.childCount; y++)
		{
			Transform obj = BottomHalf.transform.GetChild(y);

			for (int x = 0; x < obj.childCount; x++)
			{
				Transform child = obj.GetChild(x);
				m_GameGrid[x, y + TopHalf.transform.childCount] = child.GetComponentInChildren<GridNode>().BlockType;
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

	public int CalculateCollumn(bool up)
	{
		float cylinderRotation;// get cylinder rotation from 0

		if (up)
		{
			cylinderRotation = m_TopRotation;
		}

		else
		{
			cylinderRotation = m_BottomRotation;
		}


		float cartPositionX  = GetCartPos(); //between -1, 0 , 1

		float angleOfSection = 360 / m_BackgroundWidth;
		float angle = Mathf.Acos(cartPositionX) * Mathf.Rad2Deg;
		float section = Mathf.Floor((angle - cylinderRotation) / angleOfSection) % m_BackgroundWidth;

		Debug.Log("Section Collumn = " + (int)section);
		return (int)section;
	}
}

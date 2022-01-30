using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Train : MonoBehaviour
{
	#region Singleton instance
	private static Train m_Instance;                  // Private Particlemanger instance
	public static Train Instance                      // Public Particlemanager instance
	{
		get { return m_Instance; }
	}

	/// <summary>
	/// Called onn script loading,
	/// Initializes singleton and sets default values
	/// </summary>
	private void Awake()
	{
		// Initialize Singleton
		if (m_Instance != null && m_Instance != this)
			Destroy(this.gameObject);
		else
			m_Instance = this;
	}
	#endregion

	[SerializeField] float m_movedistance;
	[SerializeField] GameObject m_TopArm;
	[SerializeField] GameObject m_BottomArm;
	public bool ArmMoving = false;

	public GridType InventoryItem;
	bool HoldingItem = false;
	[SerializeField] bool m_Moving = true;
	[SerializeField] bool m_MovingRIght = true;
	[SerializeField] private float m_MovementSpeed;

	// Update is called once per frame
	void Update()
	{
		if (m_Moving)
		{
			if (m_MovingRIght)
			{
				if (transform.position.x >= m_movedistance * 0.5)
				{
					m_MovingRIght = false;
					transform.position += new Vector3(-(m_MovementSpeed * Time.deltaTime), 0, 0);
				}
				transform.position += new Vector3(m_MovementSpeed * Time.deltaTime, 0, 0);

			}
			else
			{
				if (transform.position.x <= -(m_movedistance * 0.5))
				{
					m_MovingRIght = true;
					transform.position += new Vector3(m_MovementSpeed * Time.deltaTime, 0, 0);
				}
				transform.position += new Vector3(-(m_MovementSpeed * Time.deltaTime), 0, 0);
			}
		}
	}

	public void MoveArm(float direction)
	{
		SetMoving(false);
		Debug.Log(direction);
		if (direction > 0)
		{

			if (!ArmMoving)
			{
				int x = GameManager.Instance.World.CalculateCollumn(true);
				int y = GameManager.Instance.World.FindLowestEmptyAt(x, true);
				if (!HoldingItem)
				{
					InventoryItem = GameManager.Instance.World.RemoveBlock(x, y-1, true);
					if(InventoryItem == GridType.Air)
					{
					HoldingItem = false;

					}
					else
					{
						HoldingItem = true;
					}
				}
				else
				{
					GameManager.Instance.World.PlaceBlock(x, y, true, InventoryItem);
					HoldingItem = false;
				}

				m_TopArm.GetComponent<TrainArm>().Move();
				ArmMoving = true;
			}
		}


		else
		{

			if (!ArmMoving)
			{

				int x = GameManager.Instance.World.CalculateCollumn(false);
				int y = GameManager.Instance.World.FindLowestEmptyAt(x, false);
				if (!HoldingItem)
				{
					InventoryItem = GameManager.Instance.World.RemoveBlock(x, y-1, false);
					if (InventoryItem == GridType.Air)
					{
						HoldingItem = false;

					}
					else
					{
						HoldingItem = true;
					}
				}
				else
				{
					GameManager.Instance.World.PlaceBlock(x, y, false, InventoryItem);
					HoldingItem = false;
				}

				m_BottomArm.GetComponent<TrainArm>().Move();
				ArmMoving = true;
			}


		}
	}

	public void SetMoving(bool move)
	{
		m_Moving = move;
	}
}

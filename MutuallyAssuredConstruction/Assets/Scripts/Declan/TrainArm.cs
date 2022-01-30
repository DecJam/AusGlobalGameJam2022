using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainArm : MonoBehaviour
{
	bool m_MoovingOut;
	bool m_Mooving;
	private float m_SceneHeight = 6.0f;
	private float m_MoovingSpeed = 7;

	private void Update()
	{
		if (m_Mooving)
		{
			if (m_MoovingOut)
			{
				if (Mathf.Abs(transform.localPosition.y) >= m_SceneHeight)
				{
					m_MoovingOut = false;
					transform.position += transform.up * -(m_MoovingSpeed * Time.deltaTime);
				}
				transform.position += transform.up * m_MoovingSpeed * Time.deltaTime;
			}

			else
			{
				if (Mathf.Abs(transform.localPosition.y) > 1)
				{
					transform.position += transform.up * -(m_MoovingSpeed * Time.deltaTime);
				}
				else
				{
					EndMove();
				}
			}
		}
	}

	public void EndMove()
	{
		m_Mooving = false;
		Train.Instance.ArmMoving = false;
		Train.Instance.SetMoving(true);
		GameManager.Instance.World.RotScale = 1;
	}

	public void Move()
	{
		m_Mooving = true;
		m_MoovingOut = true;
		GameManager.Instance.World.RotScale = 0;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "ResourceNode")
		{
			//other.gameObject.GetComponentInParent<ResourceNode>().Harvest();
			m_MoovingOut = false;
		}

		else if (other.gameObject.tag == "ResourceItem")
		{
			other.gameObject.transform.SetParent(Train.Instance.transform);
			other.gameObject.transform.position = Vector3.zero;
			//Train.Instance.InventoryItem = other.gameObject;
			m_MoovingOut = false;
		}
	}
}

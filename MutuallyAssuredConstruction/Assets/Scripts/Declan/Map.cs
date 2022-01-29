using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
	[SerializeField] GameObject m_Top = null;
	[SerializeField] GameObject m_Bottom = null;
	[SerializeField] private float m_RotationSpeed = 1;

	public void Rotate(Vector2 rotations)
	{
		//Debug.Log(rotations);

		m_Top.transform.rotation = Quaternion.Euler(m_Top.transform.eulerAngles + new Vector3(0, m_RotationSpeed * rotations.y * Time.deltaTime, 0));
		m_Bottom.transform.rotation = Quaternion.Euler(m_Bottom.transform.eulerAngles + new Vector3(0, m_RotationSpeed * rotations.x * Time.deltaTime, 0));

	}

}

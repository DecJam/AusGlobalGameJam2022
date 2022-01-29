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

	[SerializeField] private float m_TIckInterval;
	[SerializeField] private int m_BackgroundWidth = 45;
	[SerializeField] private int m_BackgroundHeight = 6;
	private GridType[,] m_GameGrid;
	
	private float m_Timer;
	private void Awake()
	{
		m_GameGrid = new GridType[m_BackgroundWidth, m_BackgroundHeight];
	}

	private void Update()
	{
		m_Timer += Time.deltaTime;
		if(m_Timer >= m_TIckInterval)
		{
			Tick();
			m_Timer = 0;
		}
	}

	private void Tick()
	{
		//for all nodes that grow Add a tick, 
	}
}

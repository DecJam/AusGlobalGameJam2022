using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class World : MonoBehaviour
{
		enum NodeType
		{
			Empty,
			Growth,
			ResourceNode,
			ResourceItem
		}

	class WorldNode
	{
		public WorldNode(NodeType type)
		{
			NodeType = type;
		}

		WorldNode AboveNode;
		NodeType NodeType;
		Transform NodeTransform;
	}

	List<WorldNode> m_Floor;
	[SerializeField] private float m_TIckInterval;
	[SerializeField] private float m_BackgroundWidth = 45;
	
	private float m_Timer;
	private void Awake()
	{
		m_Floor = new List<WorldNode>();
		for(int x = 0; x < m_BackgroundWidth; x ++)
		{
			WorldNode node = new WorldNode(NodeType.Empty);
			m_Floor.Add(node);
		}
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

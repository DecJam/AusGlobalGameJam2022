using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ResourceItemType
{
	Timber,
	Rubble,
	Seed1,
	Seed2,
	Seed3,
	Sticks,
}

public class ResourceItem : MonoBehaviour
{
	
	ResourceItemType m_ItemType = ResourceItemType.Timber;
	GameObject m_Node;
	private float timer;
	bool counting = true;
	private void Update()
	{
		if (counting)
		{
			timer += Time.deltaTime;
			if(timer >= 0.5f)
			{
				SpawnItem();
				counting = false;
			}
		}
	}

	public void SetType(ResourceNodeType type)
	{
		switch (type)
		{
			case ResourceNodeType.Tree:
				m_ItemType = ResourceItemType.Timber;
				break;

			case ResourceNodeType.LightTree:
				m_ItemType = ResourceItemType.Sticks;
				break;

			case ResourceNodeType.Building:
				m_ItemType = ResourceItemType.Rubble;
				break;

			case ResourceNodeType.Bush:
				m_ItemType = ResourceItemType.Seed1;
				break;

			case ResourceNodeType.Rubble:
				m_ItemType = ResourceItemType.Rubble;
				break;

			default:
				m_ItemType = ResourceItemType.Rubble;
				break;
		}
	}

	public void SpawnItem()
	{
		m_Node = Instantiate(GameManager.Instance.GetResourceItem(m_ItemType), this.transform);
	}

	public void Harvest()
	{
		Destroy(this.gameObject);
	}
}

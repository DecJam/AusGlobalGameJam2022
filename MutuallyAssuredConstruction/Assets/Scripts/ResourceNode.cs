using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ResourceNodeType
{
	Tree,
	LightTree,
	Building,
	Bush,
	Rubble,

}

public class ResourceNode : MonoBehaviour
{
	[SerializeField] ResourceNodeType m_NodeType = ResourceNodeType.Tree;
	GameObject m_Node;
	public void SpawnNode()
	{
		m_Node = Instantiate(GameManager.Instance.GetResourceNode(m_NodeType), this.transform);

	}

	public void Harvest() 
	{
		GameObject obj;
		obj = Instantiate(GameManager.Instance.m_ResourceItemPrefab, this.transform.position, this.transform.rotation);
		obj.GetComponent<ResourceItem>().SetType(m_NodeType);
		Destroy(this.gameObject);
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Map Map = null;
    [SerializeField] List<GameObject> m_ResourceNodePrefabs;
	[SerializeField] List<GameObject> m_ResourceItemPrefabs;

	[SerializeField] GameObject m_ResourceNodePrefab;
	[SerializeField] public GameObject m_ResourceItemPrefab;

	GameObject node;
	private void Start()
	{
		//node = Instantiate(m_ResourceNodePrefab, new Vector3(0,0,10), Quaternion.identity);
		//node.GetComponent<ResourceNode>().SpawnNode();
	}

    public GameObject GetResourceNode(ResourceNodeType nodeType)
	{
		GameObject obj;

		switch (nodeType)	
		{
			case ResourceNodeType.Tree:
				obj = m_ResourceNodePrefabs[0];
				break;

			case ResourceNodeType.LightTree:
				obj = m_ResourceNodePrefabs[1];
				break;

			case ResourceNodeType.Building:
				obj = m_ResourceNodePrefabs[2];
				break;

			case ResourceNodeType.Bush:
				obj = m_ResourceNodePrefabs[3];
				break;

			case ResourceNodeType.Rubble:
				obj = m_ResourceNodePrefabs[4];
				break;

			default:
				obj = null;
				break;
		}
		return obj;
	}

	public GameObject GetResourceItem(ResourceItemType itemType)
	{
		GameObject obj;
		switch (itemType)
		{
			case ResourceItemType.Timber:
				obj = m_ResourceItemPrefabs[0];
				break;

			case ResourceItemType.Rubble:
				obj = m_ResourceItemPrefabs[1];
				break;

			case ResourceItemType.Seed1:
				obj = m_ResourceItemPrefabs[2];
				break;

			case ResourceItemType.Seed2:
				obj = m_ResourceItemPrefabs[3];
				break;

			case ResourceItemType.Seed3:
				obj = m_ResourceItemPrefabs[4];
				break;

			case ResourceItemType.Sticks:
				obj = m_ResourceItemPrefabs[5];
				break;

			default:
				obj = null;
				break;
		}

		return obj;
	}
	#region Singleton instance
	private static GameManager m_Instance;                  // Private Particlemanger instance
    public static GameManager Instance                      // Public Particlemanager instance
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
}


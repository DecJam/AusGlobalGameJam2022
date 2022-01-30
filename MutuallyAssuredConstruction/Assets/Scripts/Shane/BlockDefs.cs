using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDefs : MonoBehaviour
{
    //public List<GameObject> thing = new List<GameObject>();
    #region Singleton instance
    private static BlockDefs m_Instance;                  // Private Particlemanger instance
    public static BlockDefs Instance                      // Public Particlemanager instance
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

    public List<GameObject> Blank = new List<GameObject>();

    public List<GameObject> UpperBuildingSingle = new List<GameObject>();
    public List<GameObject> UpperBuildingBase = new List<GameObject>();
    public List<GameObject> UpperBuildingMid = new List<GameObject>();
    public List<GameObject> UpperBuildingTop = new List<GameObject>();
    public List<GameObject> UpperTreeMid = new List<GameObject>();
    public List<GameObject> UpperTreeTop = new List<GameObject>();
    public List<GameObject> UpperTreeLightMid = new List<GameObject>();
    public List<GameObject> UpperTreeLightTop = new List<GameObject>();
    public List<GameObject> UpperRubble = new List<GameObject>();
    public List<GameObject> UpperBush = new List<GameObject>();
    public List<GameObject> UpperGardenBox = new List<GameObject>();

    public List<GameObject> LowerBuildingSingle = new List<GameObject>();
    public List<GameObject> LowerBuildingBase = new List<GameObject>();
    public List<GameObject> LowerBuildingMid = new List<GameObject>();
    public List<GameObject> LowerBuildingTop = new List<GameObject>();
    public List<GameObject> LowerTreeMid = new List<GameObject>();
    public List<GameObject> LowerTreeTop = new List<GameObject>();
    public List<GameObject> LowerTreeLightMid = new List<GameObject>();
    public List<GameObject> LowerTreeLightTop = new List<GameObject>();
    public List<GameObject> LowerRubble = new List<GameObject>();
    public List<GameObject> LowerBush = new List<GameObject>();
    public List<GameObject> LowerGardenBox = new List<GameObject>();
}

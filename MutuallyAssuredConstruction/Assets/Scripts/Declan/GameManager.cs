using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public World World = null;

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


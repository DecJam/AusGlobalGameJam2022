using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInterface : MonoBehaviour
{
	enum UIState
	{
		Main,
		Game,
		Paused,
		Controls,
		End
	}

	[Header("MainMenuUI")]
	[SerializeField] private GameObject m_MainMenuPanel = null;

	[Header("GameUI")]
	[SerializeField] private GameObject m_GamePanel = null;

	[Header("PausedMenu")]
	[SerializeField] private GameObject m_PausedMenuPanel = null;

	[Header("ControlsUI")]
	[SerializeField] private GameObject m_ControlsUIPanel = null;

	[Header("EndMenuPanel")]
	//[SerializeField] private GameObject m_EndMenuPanel = null;

	private GameObject m_CurrentMenu = null;

	//UIState m_State = UIState.Main;
	Stack<GameObject> m_StateStack;
	private void Awake()
	{
		m_CurrentMenu = m_MainMenuPanel;
		m_StateStack = new Stack<GameObject>();
	}

	public void StartGame()
	{
		m_CurrentMenu.SetActive(false);
		m_GamePanel.SetActive(true);
		m_CurrentMenu = m_GamePanel;

		m_StateStack.Clear();
		m_StateStack.Push(m_CurrentMenu);

		//GameManager.Instance.StartGame();
		Debug.Log("Starting Game");
	}

	public void LoadControls()
	{
		m_CurrentMenu.SetActive(false);
		m_ControlsUIPanel.SetActive(true);
		m_CurrentMenu = m_ControlsUIPanel;

		m_StateStack.Push(m_CurrentMenu);

		Debug.Log("Loading Controls");
	}

	public void LoadMenu()
	{
		m_CurrentMenu.SetActive(false);
		m_MainMenuPanel.SetActive(true);
		m_CurrentMenu = m_MainMenuPanel;

		m_StateStack.Clear();
		m_StateStack.Push(m_CurrentMenu);

		Debug.Log("Loading Menu");
	}

	public void TogglePause() // Previous menu
	{
		if(m_CurrentMenu != m_PausedMenuPanel)
		m_StateStack.Pop().SetActive(false);
	//	m_StateStack.
	}

	public void ExitToDesktop()
	{
		Application.Quit();
	}
}

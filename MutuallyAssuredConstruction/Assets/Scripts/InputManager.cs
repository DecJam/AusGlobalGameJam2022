using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
	private Controls m_PlayerInput;
	Vector2 mousepos;
	[SerializeField] LayerMask m_ResourceNode;

	private void Awake()
	{
		m_PlayerInput = new Controls();

		m_PlayerInput.Default.mouseclick.performed += ctx => MouseClick(ctx);
		m_PlayerInput.Default.Arms.performed += ctx => MoveArms(ctx);

	}
	private void Update()
	{
		//RotationInput(m_PlayerInput.Default.SideMovement.ReadValue<Vector2>());
		//mousepos = m_PlayerInput.Default.mousePos.ReadValue<Vector2>();
	}

	private void RotationInput(Vector2 rotation)
	{
		GameManager.Instance.Map.Rotate(rotation);
	}

	public void MouseClick(InputAction.CallbackContext ctx)
	{
		RaycastHit hit;
		if(Physics.Raycast(Camera.main.ScreenPointToRay(mousepos), out hit, float.MaxValue, m_ResourceNode))
		{
			hit.collider.gameObject.GetComponentInParent<ResourceNode>().Harvest();
		}
	} 
	private void MoveArms(InputAction.CallbackContext ctx)
	{
		Train.Instance.MoveArm(ctx.ReadValue<float>());
	}

	#region Enable/Disable
	private void OnEnable()
	{
		m_PlayerInput.Enable();
	}

	private void OnDisable()
	{
		m_PlayerInput.Disable();
	}
	#endregion
}

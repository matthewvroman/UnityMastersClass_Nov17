using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {

	[SerializeField] private Rigidbody m_rigidbody;
	[SerializeField] private float m_speed;
	[SerializeField] private float m_jumpForce;
	[SerializeField] private bool m_useRawInput;

	private bool m_canJump = false;
	
	// Update is called once per frame
	void Update () 
	{
		float horizontalInput;
		float verticalInput;

		if (m_useRawInput) 
		{
			horizontalInput = Input.GetAxisRaw ("Horizontal");
			verticalInput = Input.GetAxisRaw ("Vertical");
		} 
		else 
		{
			horizontalInput = Input.GetAxis ("Horizontal");
			verticalInput = Input.GetAxis ("Vertical");
		}

		Vector3 velocity = m_rigidbody.velocity;
		velocity.x = horizontalInput * m_speed;
		velocity.z = verticalInput * m_speed;

		if (velocity.y == 0) 
		{
			m_canJump = true;
		}

		if (m_canJump && Input.GetButtonDown ("Jump")) 
		{
			velocity.y += m_jumpForce;
			m_canJump = false;
		}

		m_rigidbody.velocity = velocity;

	}
}

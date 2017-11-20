using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorSample : MonoBehaviour {

	[SerializeField] private Animator m_animator;

	private void Update()
	{
		float horizontalInput = Input.GetAxis ("Horizontal");
		float verticalInput = Input.GetAxis ("Vertical");
		m_animator.SetFloat ("Speed", Mathf.Abs(verticalInput) + Mathf.Abs(horizontalInput));
	}
}

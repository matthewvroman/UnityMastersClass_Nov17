using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentSample : MonoBehaviour {

	private void Awake()
	{
		Debug.Log ("Awake");
	}

	private void Start()
	{
		Debug.Log ("Start");
	}

	private void OnEnable()
	{
		Debug.Log ("OnEnable");
	}

	private void OnDisable()
	{
		Debug.Log ("OnDisable");
	}

	private void Update()
	{
		//Debug.Log ("Update");
	}

	private void LateUpdate()
	{
		//Debug.Log ("LateUpdate");
	}

	private void FixedUpdate()
	{
		//Debug.Log ("FixedUpdate");
	}

	//Requires Renderer component
	private void OnBecameVisible()
	{
		Debug.Log ("OnBecameVisible");
	}

	//Requires Renderer component
	private void OnBecameInvisible()
	{
		Debug.Log ("OnBecameInvisible");
	}

	//Requires Rigidbody and a collider
	private void OnTriggerEnter(Collider collider)
	{
		Debug.Log ("OnTriggerEnter");
	}

	//Requires Rigidbody and a collider
	private void OnTriggerStay(Collider collider)
	{
		Debug.Log ("OnTriggerStay");
	}

	//Requires Rigidbody and a collider
	private void OnTriggerExit(Collider collider)
	{
		Debug.Log ("OnTriggerExit");
	}

	//Requires Rigidbody and a collider
	private void OnCollisionEnter(Collision collision)
	{
		Debug.Log ("OnCollisionEnter");
	}

	//Requires Rigidbody and a collider
	private void OnCollisionStay(Collision collision)
	{
		Debug.Log ("OnCollisionStay");
	}

	//Requires Rigidbody and a collider
	private void OnCollisionExit(Collision collision)
	{
		Debug.Log ("OnCollisionExit");
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour {

	[SerializeField] private Vector3 m_rotationSpeed;

	private void Update()
	{
		this.gameObject.transform.Rotate (m_rotationSpeed * Time.deltaTime);
	}
}

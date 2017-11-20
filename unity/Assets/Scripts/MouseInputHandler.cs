using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputHandler : MonoBehaviour {

	[SerializeField] private Camera m_camera;
	[SerializeField] private GameObject m_prefabToSpawn;
	[SerializeField] private Vector3 m_spawnOffset;

	void Update () 
	{
		if (Input.GetButtonDown ("Fire1")) 
		{
			Vector3 mousePosition = Input.mousePosition;
			Ray ray = m_camera.ScreenPointToRay (mousePosition);
			RaycastHit hitInfo;
			if (Physics.Raycast (ray, out hitInfo)) 
			{
				Vector3 spawnPosition = hitInfo.point + m_spawnOffset;
				GameObject.Instantiate (m_prefabToSpawn, spawnPosition, Quaternion.identity);
			}
		}

	}
}

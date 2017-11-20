using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitlePanel : MonoBehaviour {

	[SerializeField] private Button m_playButton;
	[SerializeField] private GameObject m_nextPanel;

	private void OnEnable()
	{
		m_playButton.onClick.AddListener(OnPlayButtonClicked);
	}

	private void OnDisable()
	{
		m_playButton.onClick.RemoveListener(OnPlayButtonClicked);
	}

	private void OnPlayButtonClicked()
	{
		this.gameObject.SetActive(false);
		m_nextPanel.SetActive (true);
	}
}

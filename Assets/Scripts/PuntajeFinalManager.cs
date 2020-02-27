using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuntajeFinalManager : MonoBehaviour
{
	public TextMeshProUGUI text;
	string score;

	void Start()
	{
		score = string.Format("Puntaje final: {0}", GameManager.Score);
	}

	void Update()
	{
		score = string.Format("Puntaje final: {0}", GameManager.Score);
		text.text = score;
	}
}

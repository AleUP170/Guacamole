using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
	LevelManager levelManagerScript;
	public GameObject lmGO;
	int scoreInt;
	public TextMeshProUGUI text;
	string score;

	void Start()
	{
		levelManagerScript = lmGO.GetComponent<LevelManager>();
		scoreInt = levelManagerScript.puntaje;
		score = string.Format("Puntaje: {0}", scoreInt);
	}

	void Update()
    {
		scoreInt = levelManagerScript.puntaje;
		score = string.Format("Puntaje: {0}", scoreInt);
		text.text = score;
	}
}

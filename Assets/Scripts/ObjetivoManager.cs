using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjetivoManager : MonoBehaviour
{
	LevelManager levelManagerScript;
	public GameObject lmGO;
	public TextMeshProUGUI text;
	string objetivo;

	void Start()
	{
		levelManagerScript = lmGO.GetComponent<LevelManager>();
		objetivo = string.Format("Objetivo: {0}", levelManagerScript.grupoElegido);
	}

	private void Update()
	{
		objetivo = string.Format("Objetivo: {0}", levelManagerScript.grupoElegido);
		text.text = objetivo;
	}

}
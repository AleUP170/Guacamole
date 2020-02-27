using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TiempoManager : MonoBehaviour
{
	LevelManager levelManagerScript;
	public GameObject lmGO;
	int tiempoInt;
	public TextMeshProUGUI text;
	string tiempo;

	void Start()
	{
		levelManagerScript = lmGO.GetComponent<LevelManager>();
		tiempoInt = (int)levelManagerScript.timer;
		tiempo = string.Format("Puntaje: {0}", tiempoInt);
	}

	void Update()
	{
		tiempoInt = (int)levelManagerScript.timer;
		tiempo = string.Format("Tiempo\n{0}", tiempoInt);
		text.text = tiempo;
	}
}

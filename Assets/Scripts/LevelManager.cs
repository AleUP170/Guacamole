using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	private string[] grupos; 
	public string grupoElegido;
	int randAux;
	public int puntaje;
	public float timer;
	public GameObject menuPausa, botonPausa, martillo;

	void Start()
	{
		grupos = new string[5] { "Origen Animal", "Cereal", "Fruta", "Leguminosa", "Verdura" };
		puntaje = 0;
		ElegirGrupo();
		timer = 100f - (GameManager.LevelNumber - 1)*10;
		Mathf.Clamp(timer, 40f, 100);
		Time.timeScale = 1;
	}

    void Update()
    {
		if (Time.timeScale != 0 && timer > 0)
		{
			timer -= Time.deltaTime;
		}

		if (timer <= 0)
		{
			Final();
		}
	}

	public void ElegirGrupo()
	{
		randAux = Random.Range(0, 5);
		grupoElegido = grupos[randAux];
	}

	void Final()
	{
		GameManager.Score = puntaje;
		if (puntaje >= 10)
		{
			GameManager.Flag = true;
		}
		else
		{
			GameManager.Flag = false;
		}
		Invoke("CargarSigNivel",1.5f);
		martillo.SetActive(false);
	}

	public void Pausa()
	{
		if (Time.timeScale == 0)
		{
			menuPausa.SetActive(false);
			botonPausa.SetActive(true);
			Time.timeScale = 1;
		}
		else
		{
			menuPausa.SetActive(true);
			botonPausa.SetActive(false);
			Time.timeScale = 0;
		}
	}

	public void Regresar()
	{
		SceneManager.LoadScene("PantallaPrincipal");
	}

	public void CargarSigNivel()
	{
		SceneManager.LoadScene("GameOver");
	}
}

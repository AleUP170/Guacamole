using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
	public GameObject reiniciar, continuar;

    void Start()
    {
		if (GameManager.Flag)
		{
			reiniciar.SetActive(false);
			continuar.SetActive(true);
		}
		else
		{
			reiniciar.SetActive(true);
			continuar.SetActive(false);
		}
    }

	public void Reintentar()
	{
		GameManager.LevelNumber = 1;
		SceneManager.LoadScene("Juego");
	}

	public void Continuar()
	{
		GameManager.LevelNumber++;
		SceneManager.LoadScene("Juego");
	}

	public void Regresar()
	{
		SceneManager.LoadScene("PantallaPrincipal");
	}
}

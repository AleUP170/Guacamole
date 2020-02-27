using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
	public GameObject principal, tutorialMain, tutorial1, tutorial2, creditos;

    public void EmpezarJuego()
    {
		GameManager.LevelNumber = 1;
		SceneManager.LoadScene("Juego");
    }

	public void AbrirTutorial1()
	{
		principal.SetActive(false);
		creditos.SetActive(false);
		tutorial1.SetActive(true);
		tutorial2.SetActive(false);
		tutorialMain.SetActive(true);
	}

	public void AbrirTutorial2()
	{
		principal.SetActive(false);
		creditos.SetActive(false);
		tutorial1.SetActive(false);
		tutorial2.SetActive(true);
		tutorialMain.SetActive(true);
	}

	public void AbrirPrincipal()
	{
		principal.SetActive(true);
		creditos.SetActive(false);
		tutorial1.SetActive(false);
		tutorial2.SetActive(false);
		tutorialMain.SetActive(false);
	}

	public void AbrirCreditos()
	{
		principal.SetActive(false);
		creditos.SetActive(true);
		tutorial1.SetActive(false);
		tutorial2.SetActive(false);
		tutorialMain.SetActive(false);
	}

	public void Salir()
	{
		Application.Quit();
	}
}

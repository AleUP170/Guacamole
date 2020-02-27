using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
	private void Awake()
	{
		GameObject[] objs = GameObject.FindGameObjectsWithTag("Musica");

		if (objs.Length > 1)
		{
			Destroy(this.gameObject);
		}
		else
		{
			DontDestroyOnLoad(gameObject);
		}
	}
}

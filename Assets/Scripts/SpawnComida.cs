using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnComida : MonoBehaviour
{
	public GameObject[] animales, cereales, verduras, frutas, leguminosas;
	GameObject[] randList;
	float invokeTimer;
	int randAux;

	// Start is called before the first frame update
	void Start()
    {
		invokeTimer = Random.Range(1.0f, 8.0f)  + Random.Range(0.1f, 0.9f);
		Invoke("CrearComida", invokeTimer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void CrearComida()
	{
		randAux = Random.Range(0, 5);
		switch (randAux)
		{
			case 0:
				randAux = Random.Range(0, 6);
				Instantiate(animales[randAux], transform.position, Quaternion.identity);
				break;

			case 1:
				randAux = Random.Range(0, 4);
				Instantiate(cereales[randAux], transform.position, Quaternion.identity);
				break;

			case 2:
				randAux = Random.Range(0, 6);
				Instantiate(verduras[randAux], transform.position, Quaternion.identity);
				break;

			case 3:
				randAux = Random.Range(0, 5);
				Instantiate(frutas[randAux], transform.position, Quaternion.identity);
				break;

			case 4:
				randAux = Random.Range(0, 2);
				Instantiate(leguminosas[randAux], transform.position, Quaternion.identity);
				break;

			default:
				break;
		}
		invokeTimer = Random.Range(7.0f, 15.0f) + Random.Range(0.1f, 0.9f);
		Invoke("CrearComida", invokeTimer);
	}
}

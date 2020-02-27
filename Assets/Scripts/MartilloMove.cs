using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MartilloMove : MonoBehaviour
{
	Vector2 mousePos;
	RaycastHit2D hit;
	LevelManager levelManagerScript;
	public AudioSource hitAudio;
	public GameObject lmGO;

	void Start()
    {
		levelManagerScript = lmGO.GetComponent<LevelManager>(); 
    }
	
    void Update()
    {
		if (Time.timeScale != 0)
		{
			transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f));
			transform.position = new Vector3(transform.position.x, transform.position.y, 0f);
		}

		if (Input.GetMouseButtonDown(0) && Time.timeScale != 0)
		{
			mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			hit = Physics2D.Raycast(mousePos, Vector2.zero);
			hitAudio.Play();
		}
		if (hit.collider != null && Time.timeScale != 0)
		{
			if (hit.collider.gameObject.tag == levelManagerScript.grupoElegido)
			{
				levelManagerScript.puntaje++;
			}
			else
			{
				if (levelManagerScript.puntaje > 0)
				{
					levelManagerScript.puntaje--;
				}
			}
			Destroy(hit.collider.transform.parent.gameObject);
			Destroy(hit.collider.gameObject);
		}
	}
}

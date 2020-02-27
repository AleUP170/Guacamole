using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBehaviour : MonoBehaviour
{
    
    void Start()
    {
		if (transform.position.y > 1f)
		{
			GetComponent<SpriteRenderer>().sortingOrder = 3;
		}
		else if (transform.position.y < -2f)
		{
			GetComponent<SpriteRenderer>().sortingOrder = 7;
		}
		else
		{
			GetComponent<SpriteRenderer>().sortingOrder = 5;
		}

		Invoke("DespawnFood", 4);
	}
	

	void DespawnFood()
	{
		Destroy(transform.parent.gameObject);
		Destroy(gameObject);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Do : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
		
	}

    void OnTriggerEnter(Collider other)
	{
		if(other.name == "Player1")
		{ Destroy(gameObject); 
	}
		if (other.tag == "Coin")
		{
			score += 10;
			Destroy(other.gameObject); // Or whatever way you want to remove the coin.
		}
}
		
}

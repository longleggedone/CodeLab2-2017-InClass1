using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject[] sprites;

	// Use this for initialization
	void Start () {
		InvokeRepeating("SpriteTime",1,1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SpriteTime(){
		int nextNum = GetComponent<NumberGenerator>().Next();

		MakeSprite(nextNum);
	}

	void MakeSprite(int num){
		Instantiate (sprites[num], transform.position, Quaternion.Euler(0, 0, Random.Range(0, 360)));
	}
}

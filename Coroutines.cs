using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (PrintingAsTimePasses(5));
	}

	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator PrintingAsTimePasses (int delay) {
		print ("Hello First!");

		//сначало выполниться до конца целая функция
		//yield return StartCoroutine (CountTo10 ());

		//Сделает вызов функции паралельно
		StartCoroutine (CountTo10 ());

		print ("Hello World!");
		yield return new WaitForSeconds (delay * 2);
		print ("Hi man, are you're hearing me?");
	}

	IEnumerator CountTo10 () {
		for (int i = 0; i <= 10; i++) {
			print (i);
			yield return new WaitForSeconds (1f);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImolentationConstructor : MonoBehaviour {

	public PersonConstructor man2;

	// Use this for initialization
	void Start () {
		
		//Локальная переменная, не указываем тип доступа.
		PersonConstructor man = new PersonConstructor ("Masha", 1193, 26, "Dmitrieva 5/1", "Omsk", "Russia");

		man2 = new PersonConstructor ("Vitaliy", 2894, 25);

		PrintManInformation (man);
		PrintManInformation (man2);
	}

	void PrintManInformation (PersonConstructor person){
		print (
			person.name + ", " + 
			person.id + ", " + 
			person.age + ", " + 
			person.address + ", " + 
			person.city + ", " + 
			person.country
		);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

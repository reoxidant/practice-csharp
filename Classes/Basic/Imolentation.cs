using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imolentation : MonoBehaviour {

	public Person man2;

	// Use this for initialization
	void Start () {
		
		//Локальная переменная, не указываем тип доступа.
		Person man = new Person ();

		man.name = "Masha";
		man.id = 1193;
		man.age = 26;
		man.address = "Dmitrieva 5/1";
		man.city = "Omsk";
		man.country = "Russia";

		man2 = new Person ();

		man2.name = "Vitaliy";
		man2.id = 2894;
		man2.age = 25;
		man2.address = "Dmitrieva 5/1";
		man2.city = "Omsk";
		man2.country = "Russia";

		PrintManInformation (man);
		PrintManInformation (man2);
	}

	void PrintManInformation (Person person){
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

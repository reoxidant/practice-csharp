using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImolentationStatic : MonoBehaviour {

	public PersonStatic man2;

	// Use this for initialization
	void Start () {
		
		//Локальная переменная, не указываем тип доступа.
		PersonStatic man = new PersonStatic ("Masha", 1193, 26, "Dmitrieva 5/1", "Omsk", "Russia", DatingStatusStatic.Single);

		man2 = new PersonStatic ("Vitaliy", 2894, 25, "Dmitrieva 5/1", "Omsk", "Russia", DatingStatusStatic.Single);

		PrintManInformation (man);
		PrintManInformation (man2);

		PersonStatic.Propose (man, man2);

//		man.Propose (man2);

		PrintManInformation (man);
		PrintManInformation (man2);
//		print (PersonStatic.species);
	}

	void PrintManInformation (PersonStatic person){
		print (
			person.name + ", " + 
			person.datingStatus + ", " +
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

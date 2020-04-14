using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImolentationEncapsulator : MonoBehaviour {

	public PersonEncapsulator man2;

	// Use this for initialization
	void Start () {
		
		//Локальная переменная, не указываем тип доступа.
		PersonEncapsulator man = new PersonEncapsulator ("Masha", 1193, 26, "Dmitrieva 5/1", "Omsk", "Russia", DatingStatusEncapsulator.Single);

		man2 = new PersonEncapsulator ("Vitaliy", 2894, 25, "Dmitrieva 5/1", "Omsk", "Russia", DatingStatusEncapsulator.Single);

		PrintManInformation (man2);

//		man2.Age = 35;
//		man2.Age = -30;

		//С помощью методов.
		man.GetAge();
		man2.SetAge(40);
	
		PrintManInformation (man2);
	}

	void PrintManInformation (PersonEncapsulator person){
		print (
			person.name + ", " + 
			person.datingStatus + ", " +
			person.id + ", " + 
			person.Age + ", " + 
			person.address + ", " + 
			person.city + ", " + 
			person.country
		);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

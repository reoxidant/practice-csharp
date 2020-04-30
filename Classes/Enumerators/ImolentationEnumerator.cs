using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImolentationEnumerator : MonoBehaviour {

	public PersonEnumerator man2;

	// Use this for initialization
	void Start () {
		
		//Локальная переменная, не указываем тип доступа.
		PersonEnumerator man = new PersonEnumerator ("Masha", 1193, 26, "Dmitrieva 5/1", "Omsk", "Russia", DatingStatus.Single);

		man2 = new PersonEnumerator ("Vitaliy", 2894, 25, "Dmitrieva 5/1", "Omsk", "Russia", DatingStatus.Single);

		PrintManInformation (man);
		PrintManInformation (man2);

		man.Propose (man2);

		PrintManInformation (man);
		PrintManInformation (man2);

	}

	void PrintManInformation (PersonEnumerator person){
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

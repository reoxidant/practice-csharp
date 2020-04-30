using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DatingStatus{
	Single,
	ItsComplicated,
	Dating
}

[System.Serializable]
public class PersonEnumerator {
	
	//Опишем человека
	public int age, id;
	public string name, address, city, country;
	public DatingStatus datingStatus;

	//Все переданные значение начинаются с большой буквы
	public PersonEnumerator (string Name, int Id, int Age, string Address, string City, string Country, DatingStatus LegalStatus){
		name = Name;
		id = Id;
		age = Age;
		address = Address;
		city = City;
		country = Country;
		datingStatus = LegalStatus;
	}

	//без this

//	public PersonEnumerator (string Name, int Id, int Age){
//		name = Name;
//		id = Id;
//		age = Age;
//
//		address = city = country = "N/A";
//		//тоже самое что и сверху
////		address = "N/A";
////		city = "N/A";
////		country = "N/A";
//	}

	//this это то что именно внутри класса

	public PersonEnumerator (string name, int id, int age){
		this.name = name;
		this.id = id;
		this.age = age;
		this.address = city = country = "N/A";
	}

	public void Propose (PersonEnumerator anotherPerson){
		if (anotherPerson.datingStatus == DatingStatus.Single && datingStatus == DatingStatus.Single) {
			anotherPerson.datingStatus = datingStatus = DatingStatus.Dating;
		}
	}
}

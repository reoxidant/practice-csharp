using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DatingStatusStatic{
	Single,
	ItsComplicated,
	Dating
}

[System.Serializable]
public class PersonStatic {
	
	//Опишем человека
	public int age, id;
	public string name, address, city, country;
	public DatingStatusStatic datingStatus;
	public static string species = "Homo Sapiens";
	public static string planet = "Earth";

	//Все переданные значение начинаются с большой буквы
	public PersonStatic (string Name, int Id, int Age, string Address, string City, string Country, DatingStatusStatic LegalStatus){
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

	public PersonStatic (string name, int id, int age){
		this.name = name;
		this.id = id;
		this.age = age;
		this.address = city = country = "N/A";
	}

	public void Propose (PersonStatic anotherPerson){
		if (anotherPerson.datingStatus == DatingStatusStatic.Single && datingStatus == DatingStatusStatic.Single) {
			anotherPerson.datingStatus = datingStatus = DatingStatusStatic.Dating;
		}
	}
		
	public static void Propose (PersonStatic a, PersonStatic b){
		if(a.datingStatus == DatingStatusStatic.Single && b.datingStatus == DatingStatusStatic.Single){
			a.datingStatus = b.datingStatus = DatingStatusStatic.Dating;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PersonConstructor {
	
	//Опишем человека
	public int age, id;
	public string name, address, city, country;

	//Все переданные значение начинаются с большой буквы
	public PersonConstructor (string Name, int Id, int Age, string Address, string City, string Country){
		name = Name;
		id = Id;
		age = Age;
		address = Address;
		city = City;
		country = Country;
	}

	//без this

//	public PersonConstructor (string Name, int Id, int Age){
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

	public PersonConstructor (string name, int id, int age){
		this.name = name;
		this.id = id;
		this.age = age;
		this.address = city = country = "N/A";
	}
}
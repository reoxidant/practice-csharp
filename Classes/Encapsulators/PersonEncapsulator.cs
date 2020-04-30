using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DatingStatusEncapsulator{
	Single,
	ItsComplicated,
	Dating
}

[System.Serializable]
public class PersonEncapsulator {
	
	//Опишем человека
	public int id;
	private int age;
	public string name, address, city, country;
	public DatingStatusEncapsulator datingStatus;

	//Наш основной инкапсулятор

	public int Age {
		get{ return age; }
		set{ 
			if (value >= 0) {
				age = value;
			} else {
				age = 0;
			}
		}
	}


	// Тоже самое, что и сверху

//	public int Age() {
//		return age;
//	}

	//Реализуем инкапсулятор через методы

	public int GetAge (){
		return age;
	}

	public void SetAge(int valueOfAge){
		if (valueOfAge >= 0) {
			this.age = valueOfAge;
		} else {
			this.age = 0;
		}
	}


	//Все переданные значение начинаются с большой буквы
	public PersonEncapsulator (string Name, int Id, int Age, string Address, string City, string Country, DatingStatusEncapsulator LegalStatus){
		name = Name;
		id = Id;
		age = Age;
		address = Address;
		city = City;
		country = Country;
		datingStatus = LegalStatus;
	}

	public PersonEncapsulator(string name, int id, int age){
		this.name = name;
		this.id = id;
		this.age = age;
		this.address = city = country = "N/A";
	}

	public void Propose (PersonEncapsulator anotherPerson){
		if (anotherPerson.datingStatus == DatingStatusEncapsulator.Single && datingStatus == DatingStatusEncapsulator.Single) {
			anotherPerson.datingStatus = datingStatus = DatingStatusEncapsulator.Dating;
		}
	}
}

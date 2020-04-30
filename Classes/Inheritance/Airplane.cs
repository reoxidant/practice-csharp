using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane : FlyingThing{

	public float currentFuel, maxFuel;
	public int passengerCapacity;
	public string company;

	public Airplane (float MaxFuel, int PassengerCapacity, string Company, float Velocity) : base (Velocity){
		float maxFuel = MaxFuel;
		int passengerCapacity = PassengerCapacity;
		string company = Company;
	}	

	public override void Fly(){
		base.Fly ();
		MonoBehaviour.print ("Airplane is fly!");
	}
}

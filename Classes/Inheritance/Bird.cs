using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : FlyingThing{
	
	public bool isHungry, isThirsty;

	public Bird(float Velocity) : base(Velocity){
		
	}

	public override void Fly(){
		base.Fly ();
		MonoBehaviour.print ("Bird is fly!");
	}
}

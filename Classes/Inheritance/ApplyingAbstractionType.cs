using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyingAbstractionType : MonoBehaviour {

	public FlyingThing[] thingsThatFly;

	void Start(){
		thingsThatFly = new FlyingThing[2];
		thingsThatFly [0] = new Bird (2);
		thingsThatFly [1] = new Airplane (1000, 200, "Sony", 1000);
		thingsThatFly [0].Fly (); //bird
		thingsThatFly [1].Fly (); //Airplane
	}
}

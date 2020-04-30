using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingThing {
	protected float velocity, currentHeight;

	public float Velocity{
		get { return velocity; }
	}

	public FlyingThing (float Velocity){
		velocity = Velocity;
	}	

	//не обязательно реализовавыть в наследнике, нужнен для дописывания функционала

//	public virtual void Fly () {
//		
//	}

	public virtual void Fly (){
		MonoBehaviour.print ("Main way to fly!");
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyingInheritance : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Bird b = new Bird (1);
		print(b.Velocity);
		Airplane a = new Airplane (10000, 88, "Microsoft", 20000);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

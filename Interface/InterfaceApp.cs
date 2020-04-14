using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceApp : MonoBehaviour {

	public Enemy enemy;
	public Enemy2 enemy2;

	// Use this for initialization
	void Start () {
		(enemy as IKillAble).Die ();
		((IKillAble)enemy2).Die ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

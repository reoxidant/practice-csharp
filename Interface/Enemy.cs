using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IKillAble {

	private float _health = 100;

	public float Health
	{
		get { return _health; }
	}

	public void Die(){
		print ("I am Dying!");
	}
}

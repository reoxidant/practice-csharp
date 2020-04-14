using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour, IKillAble 
{
	private float _health;

	public float Health
	{
		get {
			return _health;
		}
	}

	public void Die()
	{
		print ("Mashan saying - I am Dying!!");
	}
}

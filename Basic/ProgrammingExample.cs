using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgrammingExample : MonoBehaviour {

	public int[] values;
	public int minimalValues;
	public int maximumValues;

	// Use this for initialization
	void Start () {
		minimalValues = values [0];
		maximumValues = values [0];

		for (int i = 1; i < values.Length; i++) 
		{
			if (values [i] < minimalValues) 
			{
				minimalValues = values [i];
			}
			if (values [i] > maximumValues)
			{
				maximumValues = values [i];
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

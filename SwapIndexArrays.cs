using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapIndexArrays : MonoBehaviour {

	public float[] array;

	// Use this for initialization
	void Start () {
		SwapIndexes (array, 2, 4);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SwapIndexes(float[] array, int indexA, int indexB)
	{
		float temporaryValue = array[indexA];
		array [indexA] = array [indexB];
		array [indexB] = temporaryValue;
	
	}
	}

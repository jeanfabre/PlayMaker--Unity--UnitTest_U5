using UnityEngine;
using System.Collections;

public class MyComponent : MonoBehaviour {

	public bool MyBool = false;

	public float MyFloat = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		MyFloat ++;

		if (! MyBool && MyFloat > 20f)
		{
			MyBool = true;
		}
	}
}

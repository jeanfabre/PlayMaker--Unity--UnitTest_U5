using UnityEngine;
using System.Collections;

public class LoadMainScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		Application.LoadLevelAdditive("My Game Scene");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

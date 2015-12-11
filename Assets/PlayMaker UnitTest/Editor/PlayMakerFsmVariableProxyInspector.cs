using System;
using System.Collections;

using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(PlayMakerFsmVariableProxy))]
public class PlayMakerFsmVariableProxyInspector : Editor {

	public override void OnInspectorGUI()
	{
		//PlayMakerFsmVariableProxy _target = (PlayMakerFsmVariableProxy)this.target;

		DrawDefaultInspector();

	}

}

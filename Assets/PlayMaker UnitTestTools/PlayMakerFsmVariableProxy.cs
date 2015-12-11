
using UnityEngine;
using System.Collections;
using HutongGames.PlayMaker;
using HutongGames.PlayMaker.Ecosystem.Utils;

/// <summary>
/// Exposes Fsm Variable into a regular Public variable of a Component, 
/// This is usefull when other assets are not able to get into PlayMaker to access Fsm Variables directly
/// Unity Unit Test Framework is a good example of where this is useful. AssertionComponent can't introspect PlayMaker, so assert this instead.
/// </summary>
public class PlayMakerFsmVariableProxy : MonoBehaviour {


	public PlayMakerFsmVariableTarget target;

	[FsmVariableTargetVariable("target")]
	public PlayMakerFsmVariable variable;
	
	public bool debug;

	void Start()
	{
		target.Initialize();
		bool found = variable.GetVariable(target);

		if (!found && debug)
		{
			Debug.LogError("Could not find "+variable+" in "+target,this);
		}
	}

	float _floatValue;
	public float floatValue
	{
		get{
			if (variable.FsmFloat!=null)
			{
				_floatValue = variable.FsmFloat.Value;
			}else{
				_floatValue = 0f;
			}

			if (debug && Application.isPlaying) Debug.Log("PlayMakerFsmVariableProxy: "+target.ToString() +"\n"+variable.ToString());

			return _floatValue;
		}
	}

	int _intValue;
	public int intValue
	{
		get{
			if (variable.FsmInt!=null)
			{
				_intValue = variable.FsmInt.Value;
			}else{
				_intValue = 0;
			}
			
			if (debug && Application.isPlaying) Debug.Log("PlayMakerFsmVariableProxy: "+target.ToString() +"\n"+variable.ToString());
			
			return _intValue;
		}
	}

	bool _boolValue;
	public bool boolValue
	{
		get{
			if (variable.FsmBool!=null)
			{
				_boolValue = variable.FsmBool.Value;
			}else{
				_boolValue = false;
			}
			
			if (debug && Application.isPlaying) Debug.Log("PlayMakerFsmVariableProxy: "+target.ToString() +"\n"+variable.ToString());
			
			return _boolValue;
		}
	}

	GameObject _gameObjectValue;
	public GameObject GameObjectValue
	{
		get{
			if (variable.FsmBool!=null)
			{
				_gameObjectValue = variable.FsmGameObject.Value;
			}else{
				_gameObjectValue = null;
			}
			
			if (debug && Application.isPlaying) Debug.Log("PlayMakerFsmVariableProxy: "+target.ToString() +"\n"+variable.ToString());
			
			return _gameObjectValue;
		}
	}

	string _stringValue;
	public string stringValue
	{
		get{
			if (variable.FsmString!=null)
			{
				_stringValue = variable.FsmString.Value;
			}else{
				_stringValue = "";
			}
			
			if (debug && Application.isPlaying) Debug.Log("PlayMakerFsmVariableProxy: "+target.ToString() +"\n"+variable.ToString());
			
			return _stringValue;
		}
	}

	Vector2 _vector2Value;
	public Vector2 vector2Value
	{
		get{
			if (variable.FsmVector2!=null)
			{
				_vector2Value = variable.FsmVector2.Value;
			}else{
				_vector2Value = Vector2.zero;;
			}
			
			if (debug && Application.isPlaying) Debug.Log("PlayMakerFsmVariableProxy: "+target.ToString() +"\n"+variable.ToString());
			
			return _vector2Value;
		}
	}

	Vector3 _vector3Value;
	public Vector3 vector3Value
	{
		get{
			if (variable.FsmVector3!=null)
			{
				_vector3Value = variable.FsmVector3.Value;
			}else{
				_vector3Value = Vector3.zero;
			}
			
			if (debug && Application.isPlaying) Debug.Log("PlayMakerFsmVariableProxy: "+target.ToString() +"\n"+variable.ToString());
			
			return _vector3Value;
		}
	}

	Color _colorValue;
	public Color colorValue
	{
		get{
			if (variable.FsmColor!=null)
			{
				_colorValue = variable.FsmColor.Value;
			}else{
				_colorValue = Color.clear;
			}
			
			if (debug && Application.isPlaying) Debug.Log("PlayMakerFsmVariableProxy: "+target.ToString() +"\n"+variable.ToString());
			
			return _colorValue;
		}
	}

	Rect _rectValue;
	public Rect rectValue
	{
		get{
			if (variable.FsmRect!=null)
			{
				_rectValue = variable.FsmRect.Value;
			}else{
				_rectValue = new Rect();
			}
			
			if (debug && Application.isPlaying) Debug.Log("PlayMakerFsmVariableProxy: "+target.ToString() +"\n"+variable.ToString());
			
			return _rectValue;
		}
	}

	Material _materialValue;
	public Material materialValue
	{
		get{
			if (variable.FsmMaterial!=null)
			{
				_materialValue = variable.FsmMaterial.Value;
			}else{
				_materialValue = null;
			}
			
			if (debug && Application.isPlaying) Debug.Log("PlayMakerFsmVariableProxy: "+target.ToString() +"\n"+variable.ToString());
			
			return _materialValue;
		}
	}

	Texture _textureValue;
	public Texture textureValue
	{
		get{
			if (variable.FsmTexture!=null)
			{
				_textureValue = variable.FsmTexture.Value;
			}else{
				_textureValue = null;
			}
			
			if (debug && Application.isPlaying) Debug.Log("PlayMakerFsmVariableProxy: "+target.ToString() +"\n"+variable.ToString());
			
			return _textureValue;
		}
	}

	Quaternion _quaternionValue;
	public Quaternion quaternionValue
	{
		get{
			if (variable.FsmQuaternion!=null)
			{
				_quaternionValue = variable.FsmQuaternion.Value;
			}else{
				_quaternionValue = Quaternion.identity;
			}
			
			if (debug && Application.isPlaying) Debug.Log("PlayMakerFsmVariableProxy: "+target.ToString() +"\n"+variable.ToString());
			
			return _quaternionValue;
		}
	}

	Object _objectValue;
	public Object objectValue
	{
		get{
			if (variable.FsmObject!=null)
			{
				_objectValue = variable.FsmObject.Value;
			}else{
				_objectValue = null;
			}
			
			if (debug && Application.isPlaying) Debug.Log("PlayMakerFsmVariableProxy: "+target.ToString() +"\n"+variable.ToString());
			
			return _objectValue;
		}
	}

	object[] _arrayValues;
	public object[] arrayValues
	{
		get{
			if (variable.FsmArray!=null)
			{
				_arrayValues = variable.FsmArray.Values;
			}else{
				_arrayValues = null;
			}
			
			if (debug && Application.isPlaying) Debug.Log("PlayMakerFsmVariableProxy: "+target.ToString() +"\n"+variable.ToString());
			
			return _arrayValues;
		}
	}
	
	System.Enum _enumValue;
	public System.Enum enumValue
	{
		get{
			if (variable.FsmEnum!=null)
			{
				_enumValue = variable.FsmEnum.Value;
			}else{
				_enumValue = null;
			}
			
			if (debug && Application.isPlaying) Debug.Log("PlayMakerFsmVariableProxy: "+target.ToString() +"\n"+variable.ToString());
			
			return _enumValue;
		}
	}

}

using UnityEngine;
using System.Collections;
using System;

public class Model : Element {

	private Nullable<int> _leftFingerID = null;
	private Nullable<int> _rightFingerID = null;

	private int _score;
	private int _recordScore;

	[Header("Constants")]

	[SerializeField]
	private float _touchRadius;


	public int score{ get { return _score; } set { _score = value; } }
	public int recordScore{ get { return recordScore; } }
	public float touchRadius{ get { return _touchRadius; } } 
	public Nullable<int> leftFingerID{ get { return _leftFingerID; }  set { _leftFingerID = value; }}
	public Nullable<int> rightFingerID{ get {return _rightFingerID; } set { _rightFingerID = value; }}

	public void initialize()
	{
		_score = 0;
		if (PlayerPrefs.HasKey ("record"))
			_recordScore = PlayerPrefs.GetInt ("record");
	}

}

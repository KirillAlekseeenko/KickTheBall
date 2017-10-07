using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class View : Element {

	[Header("Game")]

	[SerializeField]
	private BallScript _ball;
	[SerializeField]
	private Text _scoreText;
	[SerializeField]
	private InputHandlerScript _inputHandler; // touch input



	[Header("Result")]

	[SerializeField]
	private GameObject _resultPanel;
	[SerializeField]
	private Text _resultText;

	public InputHandlerScript inputHandler { get { return inputHandler; } }
	public BallScript ball { get { return _ball; } }
	public GameObject resultPanel { get { return _resultPanel; } }
	public Text scoreText { get { return scoreText; } }
	public Text resultText{ get { return _resultText; } }

}
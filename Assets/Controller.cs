using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Controller : Element {


	public void onTouchBegin(Touch touch)
	{
		GameObject leftCircle = _application.view.inputHandler.leftControl;
		GameObject rightCircle = _application.view.inputHandler.rightControl;

		if (isTouchInCircle (touch, new Vector2 (leftCircle.transform.position.x, leftCircle.transform.position.y))
			&&  _application.model.leftFingerID == null) {
			_application.model.leftFingerID = touch.fingerId;
		}

		if (isTouchInCircle (touch, new Vector2 (rightCircle.transform.position.x, rightCircle.transform.position.y))
			&&  _application.model.rightFingerID == null) {
			_application.model.rightFingerID = touch.fingerId;
		}
	}
	public void onTouchMoved(Touch touch)
	{
		if (touch.fingerId == _application.model.leftFingerID) {
			_application.view.inputHandler.leftControl.transform.position = 
				Camera.main.ScreenToWorldPoint (new Vector3(touch.position.x, touch.position.y, 0));
		}
		if (touch.fingerId == _application.model.rightFingerID) {

			_application.view.inputHandler.rightControl.transform.position = 
				Camera.main.ScreenToWorldPoint (new Vector3(touch.position.x, touch.position.y, 0));
			
		}
	}
	public void onTouchEnded(Touch touch)
	{
		if (touch.fingerId == _application.model.leftFingerID) {
			_application.model.leftFingerID = null;
		}
		if (touch.fingerId == _application.model.rightFingerID) {
			_application.model.rightFingerID = null;
		}
	}

	private bool isTouchInCircle(Touch touch, Vector2 circleCenter)
	{
		
	}

	public void gameOver()
	{
		_application.view.resultPanel.SetActive (true);
		int result = _application.model.score;
		_application.view.resultText.text = "Your score: " + result.ToString ();
		int record = _application.model.recordScore;
		if (result > record) {
				PlayerPrefs.SetInt ("record", result);
		}
	}

	public void restart()
	{
		_application.view.resultPanel.SetActive (false);
		SceneManager.LoadScene ("MainScene");
	}

}

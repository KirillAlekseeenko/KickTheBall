using UnityEngine;
using System.Collections;

public class InputHandlerScript : View {

	[SerializeField]
	private GameObject _rightControl;
	[SerializeField]
	private GameObject _leftControl;

	public GameObject rightControl{ get { return _rightControl; } }
	public GameObject leftControl { get { return _leftControl; } }

	// Update is called once per frame
	void Update () {

		if (Input.touchCount > 0) {

			Touch touches = Input.touches;

			foreach (Touch touch in touches) {
				switch (touch.phase) {
				case TouchPhase.Began:
					{
						_application.controller.onTouchBegin (touch);
						break;
					}
				case TouchPhase.Moved:
					{
						_application.controller.onTouchMoved (touch);
						break;
					}
				case TouchPhase.Canceled:
				case TouchPhase.Ended:
					{
						_application.controller.onTouchEnded (touch);
						break;
					}
				}
			}
			
		}
	
	}
}

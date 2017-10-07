using UnityEngine;
using System.Collections;

public class BallScript : View {
	public void onTriggerEnter(Collider2D collider)
	{
		if (collider.tag == "wall") {
			_application.controller.gameOver ();
		}
	}
}

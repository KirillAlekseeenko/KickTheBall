using UnityEngine;
using System.Collections;



public class Application : MonoBehaviour {

	[SerializeField]
	private Model _model;
	[SerializeField]
	private Controller _controller;
	[SerializeField]
	private View _view;



	public Model model { get{return _model;}}
	public Controller controller { get{return _controller;}}
	public View view { get{return _view;}}


	void Start(){ // don't know what it is for so far
		_model.initialize();
	}
		
}

public class Element : MonoBehaviour{

	[SerializeField]
	protected Application _application;

	/*public Application application {
		get{
			return _application;
		}
	}*/

}



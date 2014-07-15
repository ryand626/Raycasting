using UnityEngine;
using System.Collections;

public class makeCube : MonoBehaviour {

	private Button myButton;
	private bool create;

	// Use this for initialization
	void Start () {
		create = false;
		myButton = gameObject.GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) && myButton.on == true) {
			create = true;
		}

		if (create == true && myButton.on == true) {
			print ("MAKIN A THING");
			GameObject newCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			newCube.transform.position = transform.position + new Vector3(0,1.2f,0);
			create = false;
		}
	}
}

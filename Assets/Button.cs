using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
	public bool on;
	public bool textureDebounce;

	// Use this for initialization
	void Start () {
		textureDebounce = false;
		on = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (on) {
			if(textureDebounce != on){
				GetComponent<Renderer>().material = Resources.Load<Material> ("select");
				textureDebounce = on;
			}
		} else {
			if(textureDebounce != on){
				GetComponent<Renderer>().material = Resources.Load<Material>("deselect");
				textureDebounce = on;
			}
		}
	}

	void OnTriggerEnter(Collider collisionInfo){
		on = true;
	}

	void OnTriggerExit(Collider collisionInfo){
		on = false;
	}
}

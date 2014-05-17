using UnityEngine;
using System.Collections;

public class point : MonoBehaviour {

	private RaycastHit hit;
	private Ray mouseRay;
	
	// Update is called once per frame
	void Update () {
		mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast (mouseRay, out hit,100)) {
			if(hit.collider.name != "raypoint"){
				print ("Hit " + hit.collider.name);
				transform.position = (Vector3)(hit.point);
				transform.rotation = Quaternion.LookRotation(hit.normal);
			}
		}else{
			transform.position = new Vector3(200f,200f,200f);
		}
	}
}

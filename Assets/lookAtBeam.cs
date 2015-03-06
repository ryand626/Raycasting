using UnityEngine;
using System.Collections;

public class lookAtBeam : MonoBehaviour {
	public Transform target;
	public LineRenderer line;

	public Vector3 nextPosition;
	public int bounceNumber;

	// Use this for initialization
	void Start () {
		line = gameObject.AddComponent<LineRenderer> ();
		line.SetVertexCount (2);
		line.SetPosition (0, this.transform.position);
		line.SetWidth (.01f, .01f);
		bounceNumber = 1;
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (target);
		shootLine ();

		checkHit ();
	}

	void shootLine(){
		nextPosition = Vector3.Lerp (transform.position, target.position, Time.deltaTime);
		line.SetPosition (1, target.position);
	}

	void checkHit(){
		RaycastHit hit;
		Ray testRay = new Ray(transform.position, target.position - transform.position);
		Debug.DrawRay (testRay.origin, testRay.direction);

		if(Physics.Raycast(testRay, out hit, 100)){
			print ("RAYCASTIN");
			line.SetPosition(1,hit.point);
			line.SetVertexCount(3);
			line.SetPosition(2, (hit.point-Vector3.Reflect(testRay.direction,hit.normal)*-1));
			Debug.DrawRay(hit.point,Vector3.Reflect(testRay.direction,hit.normal));
		}
	}
}

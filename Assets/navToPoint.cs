using UnityEngine;
using System.Collections;

public class navToPoint : MonoBehaviour {

	public Transform target;
	NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		agent = gameObject.GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (target) {
			if(Input.GetMouseButtonDown(0)){
				agent.SetDestination(target.position);
			}
		}
	}
}

using UnityEngine;
using System.Collections;

public class SunRays : MonoBehaviour {

	public GameObject sun;


	private Vector3 dirToSun;
	int layerMask = 1 << 8;

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {

		dirToSun = sun.transform.position - transform.position;

		RaycastHit hit;
		if (Physics.Raycast(transform.position, dirToSun, out hit, 2000, layerMask))
		{
			//Debug.Log ("shadowed by " + hit.transform);
		}
		else 
		{
			//Debug.Log ("not shadowed");
		}

	
	}
}

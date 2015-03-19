using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	public float speed;


	private Rigidbody rb;
	private float x;
	private float y;
	private Vector3 moveForce;

	public float sensitivityX = 2.0f;
	
	float currentRotation;
	
	Quaternion originalRotation;

	// Use this for initialization
	void Awake () {
	
		rb = GetComponent<Rigidbody>();
		originalRotation = transform.localRotation;
	}
	
	// Update is called once per frame
	void Update () {

		float turn = Input.GetAxis("Horizontal");
		float z = Input.GetAxis ("Vertical");
		moveForce = new Vector3 (0, 0, z * speed);

		currentRotation += turn * sensitivityX;
		
		Quaternion xQuaternion = Quaternion.AngleAxis (currentRotation, Vector3.up);
		
		transform.localRotation = originalRotation * xQuaternion;
	
	}

	void FixedUpdate()
	{
		rb.AddRelativeForce(moveForce);
	}
}

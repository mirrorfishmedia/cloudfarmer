using UnityEngine;
using System.Collections;

public class MoveCloud : MonoBehaviour {


	public float speedMin = .1f;
	public float speedMax = 1;
	public float windSpeedChangeRate = 5;

	private float speed;
	private Rigidbody rb;
	private float x;
	private float y;
	private Vector3 moveForce;
	private float zHeight;

	// Use this for initialization
	void Awake () {
		
		rb = GetComponent<Rigidbody>();
	}

	void Start()
	{
		zHeight = transform.position.z;
		InvokeRepeating ("SetWindSpeed", 0, windSpeedChangeRate);

	}

	// Update is called once per frame
	void Update () {

		moveForce = new Vector3 (0, 0, 1 * speed);
		
	}

	void SetWindSpeed()
	{
		speed = Random.Range (speedMin,speedMax) * (zHeight * .01f);
	}

	void FixedUpdate()
	{
		rb.AddRelativeForce(moveForce);
	}
}

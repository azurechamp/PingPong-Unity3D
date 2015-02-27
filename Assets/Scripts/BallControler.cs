using UnityEngine;
using System.Collections;

public class BallControler : MonoBehaviour {


	//Integeres for Ball Control
	int Invert;
	public int TowardsPlayer = 1;


	// Use this for initialization
	void Start () {

		Invert = 1;
		TowardsPlayer = 1;
		rigidbody.velocity = new Vector3 (10.0f, 0.0f, 5.0f);


	}
	
	// Update is called once per frame
	void Update () {
	
		if (transform.position.z < -5.5f) {

			
			GameObject.Find("Main Camera").GetComponent<Score>().IncreaseScore(1);
			Start();
			transform.position =  Vector3.zero;

		}
		if (transform.position.z > 5.5f) {

			GameObject.Find("Main Camera").GetComponent<Score>().IncreaseScore(2);

			Start();
			transform.position =  Vector3.zero;
			
		}
	}

	
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "wall") {
			Invert = Invert* -1;

			rigidbody.velocity = new Vector3 (10.0f * Invert, 0.0f, -5.0f * TowardsPlayer );

		}
		else if (collision.gameObject.name == "player") {

			TowardsPlayer = 1;
			rigidbody.velocity = new Vector3 (10.0f * Invert, 0.0f, -5.0f);
			
		}
		else if (collision.gameObject.name == "enemy") {
			
			TowardsPlayer = -1;
			rigidbody.velocity = new Vector3 (10.0f * Invert, 0.0f, 5.0f);
			
		}
	}
}

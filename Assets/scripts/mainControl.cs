using UnityEngine;
using System.Collections;




public class mainControl : MonoBehaviour {

	public float strafeSpeed = 1.0F;
	public static float snailSpeed = 6.0F;
	//public float Speed = 100.0F;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		/*
		if(Input.GetKey ("up")) {
			transform.Translate((Vector3.forward * (Time.deltaTime)) * snailSpeed);
		}
		*/

		transform.Translate((Vector3.forward * (Time.deltaTime)) * snailSpeed);

		// Setting up left and right control
		if (Input.GetKey("left")) {
			//Debug.Log(Input.GetKey("left"));
			transform.Translate(Vector3.left * (Time.deltaTime * strafeSpeed) );
		}
		else if(Input.GetKey ("right")) {
			transform.Translate(Vector3.right * (Time.deltaTime * strafeSpeed) );
		}


		/*if (Input.GetButtonDown("Horizontal")) {
			Debug.Log(Input.GetKey("left"));
		}*/
	}

	void Example() {
		collider.material.dynamicFriction = 1;
	}
}

using UnityEngine;
using System.Collections;


 

public class mainControl2 : MonoBehaviour {

	public float SpeedAdjust = 1.0F;
	//public float Speed = 100.0F;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		/*
		if(Input.GetKey ("up")) {
			transform.Translate((Vector3.forward * (Time.deltaTime)) * Speed);
		}

		// Setting up left and right control
		if (Input.GetKey("left")) {
			//Debug.Log(Input.GetKey("left"));
			transform.Translate(Vector3.left * (Time.deltaTime * strafeSpeed) );
		}
		else if(Input.GetKey ("right")) {
			transform.Translate(Vector3.right * (Time.deltaTime * strafeSpeed) );
		}
		*/

		/*if (Input.GetButtonDown("Horizontal")) {
			Debug.Log(Input.GetKey("left"));
		}*/
	}
	/*
	void Example() {
		collider.material.dynamicFriction = 1;
	}
	*/ 
	/*
	void OnTriggerEnter(Collider other) {
		//Destroy(other.gameObject);
		//Debug.Log(other.gameObject.tag);

		if (other.gameObject.tag == "Player") {
			//Destroy (other.gameObject);
			this.gameObject.renderer.material.color = Color.blue;
		}

	}
	*/
}

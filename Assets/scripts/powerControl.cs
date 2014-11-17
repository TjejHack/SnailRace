using UnityEngine;
using System.Collections;

public class powerControl : MonoBehaviour {

	public float SpeedAdjust = 1.0F;

	// Use this for initialization
	void Start () {
		GameObject thePlayer = GameObject.FindWithTag("Player");
		mainControl playerScript = thePlayer.GetComponent<mainControl>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		//Destroy(other.gameObject);
		//Debug.Log(other.gameObject.tag);
		
		if (other.gameObject.tag == "Player") {
			//Destroy (other.gameObject);
			this.gameObject.renderer.material.color = Color.blue;

			GameObject.FindWithTag("Player").renderer.material.color = Color.red;

			//Debug.Log( mainControl.snailSpeed );

			mainControl.snailSpeed += SpeedAdjust;

			Debug.Log( mainControl.snailSpeed );
		}
		
	}
}

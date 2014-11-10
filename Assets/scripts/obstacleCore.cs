using UnityEngine;
using System.Collections;

public class ObstacleClass : MonoBehaviour {
	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
	}
}
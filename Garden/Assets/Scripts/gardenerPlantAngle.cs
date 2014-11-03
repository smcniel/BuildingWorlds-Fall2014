using UnityEngine;
using System.Collections;

public class gardenerPlantAngle : MonoBehaviour {

	public Transform treePrefab; // assign in inspector
	public Transform gardenerPrefab; // assign in inspector

	public float lastYvalue = 0f;



		void Update () {

		// plant based on when I turn... lookup "transform.eulerAngles" in Unity docs
			if (Mathf.Abs (transform.eulerAngles.y - lastYvalue) > 15f) {

			 Instantiate (treePrefab, transform.position, Quaternion.identity);

				}
	
		lastYvalue = transform.eulerAngles.y;
		}

		
	// transform.rotation.eulerAngles );  // transforms Quaternion to euler
	// Quaternion whatever = Quaternion.Euler( 0f, 180f, 90f);  // transforms euler into quaternion
}
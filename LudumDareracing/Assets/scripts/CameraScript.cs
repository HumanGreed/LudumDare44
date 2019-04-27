using UnityEngine;

public class CameraScript : MonoBehaviour {

	public GameObject car;
	public float x_car;
	public float y_car;
	public float z_car;
	
	
	// Update is called once per frame
	void Update () {
		// access rotation of the car
		x_car = car.transform.eulerAngles.x;
		y_car = car.transform.eulerAngles.y;
		z_car = car.transform.eulerAngles.z;

		transform.eulerAngles = new Vector3(x_car - x_car, y_car, z_car - z_car);
	}
}

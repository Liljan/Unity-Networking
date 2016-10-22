using UnityEngine;
using System.Collections;

public class Drive : MonoBehaviour {

    float speed = 10.0f;
    float rotationSpeed = 100.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0.0f, 0.0f, translation);
        transform.Rotate(0.0f, rotation, 0.0f);
	}
}

using UnityEngine;
using System.Collections;

public class FaceCamera : MonoBehaviour {
	
	void Update () {
        Debug.Log(Camera.main);

        this.transform.LookAt(Camera.main.transform.position);
        this.transform.Rotate(new Vector3(0.0f, 180.0f, 0.0f));
	}
}

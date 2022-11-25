using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    private Vector3 camPos;

    // Start is called before the first frame update
    private void Start(){
        camPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKey(KeyCode.W)) {
            camPos += Vector3.forward * 0.05f;
            gameObject.transform.position = camPos;
        }
        else if (Input.GetKey(KeyCode.S)) {
            camPos += Vector3.back * 0.05f;
            gameObject.transform.position = camPos;
        }
        else if (Input.GetKey(KeyCode.A)) {
            camPos += Vector3.left * 0.05f;
            gameObject.transform.position = camPos;
        }
        else if (Input.GetKey(KeyCode.D)) {
            camPos += Vector3.right * 0.05f;
            gameObject.transform.position = camPos;
        }
    }
}

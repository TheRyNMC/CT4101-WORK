using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnitude : MonoBehaviour
{
    public Vector 3 vec3;
        public float calculateMagnitudeVec3(Vector3 vec) {
        return Mathf.Sqrt ((vec.x * vec.x) + vec.y * vec.y) + (vec.z * vec.z));
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The Vector = " + vec3)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

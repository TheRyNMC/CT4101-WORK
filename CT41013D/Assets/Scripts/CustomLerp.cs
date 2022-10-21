using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomLerp : MonoBehaviour {
    float z;
    public float startZ, endZ;
    private void Start()
    {
        z = startZ;
    }



    public void LerpButton()
    {
        StartCoroutine(LerpFLoat());
    }
    IEnumerator LerpFLoat()
    {
        float time = 0;
        while (time < 1)
        {
            // t = easing fucntion
            float t = Mathf.Pow(time, 3);
            //lerp float = start + (end - start) * interpolator;
            z = startZ + (endZ - startZ) * t;
            time += Time.deltaTime;
            yield return null;
        }
    }

    private void Update()
    {
        transform.position = new Vector3(0, 0, z);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{

    [SerializeField]
    private float growth = 1f;

    private float t;

    //Function to call lerp from button
    public void startLerp() {
        StartCoroutine(lerp());
    }

    private IEnumerator lerp() {
        float time = 0f;
        while (time < 1f) {
            t = Easings.Quadratic.InOut(time);
            time += Time.deltaTime; 
            yield return new WaitForSeconds(Time.deltaTime);  
        }
    }

    // Update is called once per frame
    void Update(){
        transform.localScale = Vector3.one * Mathf.Lerp(1, growth, t);
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveObject : MonoBehaviour
{

    [SerializeField]
    private float growth = 1f;

    private float t;
    [SerializeField]
    private Slider slider;



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
        float rotation = Mathf.InverseLerp(0, 1, t) * 360f;
        transform.localEulerAngles = new Vector3(0f, 0f, rotation);
        slider.value = Mathf.InverseLerp(0, 1, t);
    }



}

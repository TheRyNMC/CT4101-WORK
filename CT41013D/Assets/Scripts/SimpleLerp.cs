using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleLerp : MonoBehaviour
{
    bool lerping;
    float lerpFloat;
    float xPos;
    float time = 0;
    public enum eases { 
        easeInSine, easeOutSine
    }

    public eases myEase;

    public void LerpButton() { 
        if (lerping == false) {
            StartCoroutine(LerpFloat(myEase));
            }
    }

    public void LerpReset() {
        GetComponent<TrailRenderer>().Clear();
    }


    IEnumerator LerpFloat(eases ease) {
        lerping=true;
        float time = 0;
        while(time < 1) { 
            float perc = 0;
            if (ease == eases.easeInSine) {
                perc = 1f - Mathf.Cos(time * Mathf.PI * 0.5f);
            }
            else if(ease == eases.easeOutSine){
                perc = Mathf.Sin(time * Mathf.PI * 0.5f);
            }
            lerpFloat = Lerp(0, 10, perc);
            time += Time.deltaTime;
            yield return null;
        }
        lerping = false;
    }

    public static float Lerp(float startValue, float endvalue, float t) { 
        return(startValue + (endvalue - startValue) * t);
    }

    private void Update(){
        transform.position = new Vector3(0, 0, lerpFloat);
        xPos = Time.deltaTime;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveObject : MonoBehaviour {

    [SerializeField]
    private float growth = 1f;

    private float t;
    //[SerializeField]
    // private Slider slider;

    [SerializeField] public string whichLerp;
    [SerializeField] public bool isLerping;
    [SerializeField] private Dropdown dropdown;

    //Function to call lerp from button
    public void startLerp() {
        if (isLerping == false) {
            StartCoroutine(lerp());
        }
    }

    private IEnumerator lerp() {
        isLerping = false;
        float time = 0f;
        while (time < 2) {
            if (dropdown.value == 0) {
                t = Easings.Linear(time);
                whichLerp = "Linear Lerp";
            } else if (dropdown.value == 1) {
                t = Easings.Quadratic.In(time);
                whichLerp = "Quad In";
            } else if (dropdown.value == 2) {
                t = Easings.Quadratic.Out(time);
                whichLerp = "Quad Out";
            } else if (dropdown.value == 3) {
                t = Easings.Quadratic.InOut(time);
                whichLerp = "Quad InOut";
            } else if (dropdown.value == 4) {
                t = Easings.Quadratic.Bezier(time);
                whichLerp = "Quad Bezier";
            } else if (dropdown.value == 5) {
                t = Easings.Trigonometric.SIn(time);
                whichLerp = "Trig Sine In";
            } else if (dropdown.value == 6) {
                t = Easings.Trigonometric.SOut(time);
                whichLerp = "Trig Sine Out";
            } else if (dropdown.value == 7) {
                t = Easings.Trigonometric.SinInOut(time);
                whichLerp = "Trig Sine InOut";
            } else if (dropdown.value == 8) {
                t = Easings.Elastic.EaseInElastic(time);
                whichLerp = "Ease In Elastic";
            } else if (dropdown.value == 9) {
                t = Easings.Elastic.EaseOutElastic(time);
                whichLerp = "Ease Out Elastic";
            } else if (dropdown.value == 10) {
                t = Easings.Elastic.easeInOutElastic(time);
                whichLerp = "Ease InOut Elastic";
            } else if (dropdown.value == 11) {
                t = Easings.Bounce.easeInBounce(time);
                whichLerp = "Ease In Bounce";
            } else if (dropdown.value == 12) {
                t = Easings.Bounce.easeOutBounce(time);
                whichLerp = "Ease Out Bounce";
            } else if (dropdown.value == 13) {
                t = Easings.Bounce.easeInOutBounce(time);
                whichLerp = "Ease InOut Bounce";
            } else if (dropdown.value == 14) {
                t = Easings.Cubic.easeInCubic(time);
                whichLerp = "Ease In Cubic";
            } else if (dropdown.value == 15) {
                t = Easings.Cubic.easeOutCubic(time);
                whichLerp = "Ease Out Cubic";
            } else if (dropdown.value == 16) {
                t = Easings.Cubic.easeInOutCubic(time);
                whichLerp = "Ease InOut Cubic";
            } else if (dropdown.value == 17) {
                t = Easings.Quart.easeInQuart(time);
                whichLerp = "Ease In Quart";
            } else if (dropdown.value == 18) {
                t = Easings.Quart.easeOutQuart(time);
                whichLerp = "Ease Out Quart";
            } else if (dropdown.value == 19) {
                t = Easings.Quart.easeInOutQuart(time);
                whichLerp = "Ease InOut Quart";
            } else if (dropdown.value == 20) {
                t = Easings.Quint.easeInQuint(time);
                whichLerp = "Ease In Quint";
            } else if (dropdown.value == 21) {
                t = Easings.Quint.easeOutQuint(time);
                whichLerp = "Ease Out Quint";
            } else if (dropdown.value == 22) {
                t = Easings.Quint.easeInOutQuint(time);
                whichLerp = "Ease InOut Quint";
            } else if (dropdown.value == 23) {
                t = Easings.Expo.easeInExpo(time);
                whichLerp = "Ease In Expo";
            } else if (dropdown.value == 24) {
                t = Easings.Expo.easeOutExpo(time);
                whichLerp = "Ease Out Expo";
            } else if (dropdown.value == 25) {
                t = Easings.Expo.easeInOutExpo(time);
                whichLerp = "Ease InOut Expo";
            } else if (dropdown.value == 26) {
                t = Easings.Circ.easeInCirc(time);
                whichLerp = "Ease In Circ";
            } else if (dropdown.value == 27) {
                t = Easings.Circ.easeOutCirc(time);
                whichLerp = "Ease Out Circ";
            } else if (dropdown.value == 28) {
                t = Easings.Circ.easeInOutCirc(time);
                whichLerp = "Ease InOut Circ";
            } else if (dropdown.value == 29) {
                t = Easings.Back.easeInBack(time);
                whichLerp = "Ease In Back";
            } else if (dropdown.value == 30) {
                t = Easings.Back.easeOutBack(time);
                whichLerp = "Ease Out Back";
            } else if (dropdown.value == 31) {
                t = Easings.Back.easeInOutBack(time);
                whichLerp = "Ease InOut Back";
            }
            time += Time.deltaTime;
            yield return null;
        }
    }

    // Update is called once per frame
    private void Update() {
        transform.position = Vector3.right * Mathf.Lerp(0, growth, t);
    }
}


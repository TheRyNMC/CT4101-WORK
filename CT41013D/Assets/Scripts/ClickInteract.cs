using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickInteract : MonoBehaviour {
    [SerializeField] private CanvasGroup panel;
    private TextMeshProUGUI objectText;

    private void Start() {
        if (panel != null) {
            objectText = panel.gameObject.GetComponentInChildren<TextMeshProUGUI>();
        }
    }



    void Update() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit)) {
            Debug.DrawLine(ray.origin, hit.point, Color.blue);
        }
        if (Physics.Raycast(ray, out hit)) {
            Debug.DrawLine(ray.origin, hit.point, Color.red);
            if (hit.transform.TryGetComponent(out MoveObject mo)) {
                mo.startLerp();
                StartCoroutine(RevealPanel());
                //objectText.text = "Name : " + hit.transform.name + " \n Easing = " + mo.e + " \n Returns? = " + (mo.b == true ? "True" : "False"); // mo.e and mo.b are placeholders for info of the ease and return
            }
        } 
        else {
            StartCoroutine(HidePanel());
        }
    }
    private IEnumerator RevealPanel() {
        float time = 0;
        while (time <= 1) {
            panel.alpha = Easings.Quadratic.In(time);
            time += Time.deltaTime;
            yield return new WaitForSeconds(Time.deltaTime);
        }
    }

    private IEnumerator HidePanel() {
        float time = 0;
        while (time <= 1) {
            panel.alpha = Easings.Quadratic.Out(time);
            time += Time.deltaTime;
            yield return new WaitForSeconds(Time.deltaTime);
        }
    }
}



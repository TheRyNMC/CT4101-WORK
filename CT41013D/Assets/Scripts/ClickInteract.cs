using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickInteract : MonoBehaviour {
    [SerializeField] private CanvasGroup panel;
    private TextMeshProUGUI objectText;
    public string theLerp;
    private bool Lerping;


    private void Start() {
        if (panel != null) {
            objectText = panel.gameObject.GetComponentInChildren<TextMeshProUGUI>();
        }
    }



    void Update() {
        if (Input.GetKeyDown(KeyCode.Mouse0)){ 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                Debug.DrawLine(ray.origin, hit.point, Color.blue);
                if (hit.transform.TryGetComponent(out MoveObject mo)) {
                    mo.startLerp();
                    StartCoroutine(RevealPanel());
                    theLerp = hit.transform.GetComponentInParent<MoveObject>().whichLerp;
                    Lerping = hit.transform.GetComponentInParent<MoveObject>().isLerping;
                    objectText.text = "Name : " + hit.transform.name + " \n Easing = "  + theLerp+ " \n Returns? = " + (Lerping == true ? "True" : "False"); // mo.e and mo.b are placeholders for info of the ease and return
                }
            } 
            else {
                StartCoroutine(HidePanel());
            }
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



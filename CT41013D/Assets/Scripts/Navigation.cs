using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour{
    public void reset(string sceneManager) {
        SceneManager.LoadScene(sceneManager);
    }
    public void LoadScene(int i) {
        SceneManager.LoadScene(i);
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }
    }
}

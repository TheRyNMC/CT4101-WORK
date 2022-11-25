using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour{
    public void reset(string sceneManager) {
        SceneManager.LoadScene(sceneManager);
    }
}

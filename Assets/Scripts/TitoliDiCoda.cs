using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitoliDiCoda : MonoBehaviour {

    [SerializeField] private int sceneToLoad;
    void Start() {
        
    }

    void Update() {
        if (Input.GetButtonDown("Down")) {
            SceneManager.LoadScene(sceneToLoad, LoadSceneMode.Single);
        }
    }
}

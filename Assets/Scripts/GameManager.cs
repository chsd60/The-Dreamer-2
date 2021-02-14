using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public bool activePapaGQuest1 = false;
    public bool dreamcatcher = true;
    public bool scene5SL = true;
    public GameObject papaGQuest1Obj;
    public GameObject papaGQuest1Obj2;
    public GameObject papaGQuest1SceneL;

    public GameObject dreamcatcherObj;
    public GameObject dreamcatcherDial1;

    public GameObject dialogObj;
    public GameObject sceneLObj;

    void Update() {
        if (activePapaGQuest1) {
            papaGQuest1Obj.SetActive(true);
            papaGQuest1SceneL.SetActive(false);
            papaGQuest1Obj2.SetActive(false);

        } else {
            papaGQuest1Obj.SetActive(false);
            papaGQuest1SceneL.SetActive(true);
            papaGQuest1Obj2.SetActive(true);
        }

        if (dreamcatcher) {
            dreamcatcherObj.SetActive(true);
        } else {
            dreamcatcherObj.SetActive(false);
            dreamcatcherDial1.SetActive(true);
        }

        if (scene5SL) {
            dialogObj.SetActive(true);
        } else {
            dialogObj.SetActive(false);
            sceneLObj.SetActive(true);
        }
    }

    public void PapaGQuest1() {
        activePapaGQuest1 = true;
    }

    public void Dreamcatcher() {
        dreamcatcher = false;
    }

    public void Scene5SL() {
        scene5SL = true;
    }

}

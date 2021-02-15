using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour {

    public GameObject stuf;

    private void Start() {
        StartCoroutine(BlinkAnimation());
    }
    IEnumerator BlinkAnimation() {
        while (true) {
            stuf.SetActive(true);
            yield return new WaitForSeconds(1f);
            stuf.SetActive(false);
            yield return new WaitForSeconds(1f);
        }
    }
}

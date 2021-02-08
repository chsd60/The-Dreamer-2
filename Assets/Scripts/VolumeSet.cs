using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeSet : MonoBehaviour {

    public AudioMixer mixer;

    private void Update() {
        Debug.Log(mixer);
    }
    public void SetLevel(float sliderValue) {
        mixer.SetFloat("MasterVolume", Mathf.Log10(sliderValue) * 20);
    }
}

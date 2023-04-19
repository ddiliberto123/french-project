using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class volumeSettings : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AudioMixer mixer;
    [SerializeField] Slider masterVolumeSlider;
    const string MIXER_MASTER = "MasterVolume";

    void Awake() {
        masterVolumeSlider.onValueChanged.AddListener(setMasterVolume);
    }

    void setMasterVolume(float value){
        mixer.SetFloat(MIXER_MASTER,Mathf.Log10(value) * 20);
    }
}

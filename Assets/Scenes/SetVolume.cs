using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    private AudioMixer mixer;
    private AudioSource audioSource;
    float A_sliderValue;
    private GameManager gameManager;
    GameObject BGAudio = GameObject.Find("BGAudio");

    public void Start ()
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    //public void SetLevel (float sliderValue)
    void OnGUI()
    {
        //Use Mathf.Log10(sliderValue * 20) if need decibal convertion
        //mixer.SetFloat(/*volume name*/ "audioSource.volume", sliderValue);
        
        A_sliderValue = GUI.HorizontalSlider(new Rect(25, 25, 200, 60), A_sliderValue, 0.0F, 1.0F);
        //BGAudio.volume = A_sliderValue;

        BGAudio.GetCopmonent<SetVolume>().ChangeVolume(A_sliderValue);
    }
}

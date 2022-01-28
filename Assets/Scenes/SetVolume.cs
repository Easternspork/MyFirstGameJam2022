using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundSlider : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetLevel (float sliderValue)
    {
        //Mathf.Log10 for converting .0001 to one slider value and turn it to a value between -80 and 0 on a logaritmic scale because
        //because decibal convertion
        mixer.SetFloat(/*exposed music value to scripting name ->*/"", Mathf.Log10(sliderValue * 20));
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{   
    public AudioSource sound1;//CreateGameObject Empty and add audiosource
    public AudioClip soundBtn;
    public AudioSource sound2;//CreateGameObject Empty and add audiosource
    public AudioClip soundCursor;

    public void SoundButton()//This function is called from the Button through the component Event Trigger.
    {
        sound1.clip = soundBtn;
        //Turn sound on and off
        sound1.enabled = false;
        sound1.enabled = true;
    }

    public void SoundCursorP()
    {
        sound2.clip = soundCursor;
        //Turn sound on and off
        sound2.enabled = false;
        sound2.enabled = true;
    }
}

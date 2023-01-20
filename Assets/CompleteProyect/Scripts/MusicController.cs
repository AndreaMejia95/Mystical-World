using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    public GameObject panelPause;
    public GameObject panelMusic;

    public Slider music;            //Music Level
    public Slider character;       // Shots, attack, walking,
    public Slider enviroment;      //Nature, Fire, Cuve, lake.
    //public Slider Overall;         Every Sound

    public GameObject[] audiosMusic;         //Lista para ubicar todos los objetos que encuentre.
    public GameObject[] characterMusic;
    public GameObject[] enviromentMusic;

    private void Start()
    {
        audiosMusic = GameObject.FindGameObjectsWithTag("MusicLev");  //Fetch audio with tag
        characterMusic = GameObject.FindGameObjectsWithTag("Character");  //Fetch audio with tag
        enviromentMusic = GameObject.FindGameObjectsWithTag("Enviroment");  //Fetch audio with tag
        
        music.value = PlayerPrefs.GetFloat("volumenSave", 1f); //Carga la informaci� preguardada de no tenerla lo deja con valor 1.
        character.value = PlayerPrefs.GetFloat("volumenSave", 1f);
        enviroment.value = PlayerPrefs.GetFloat("volumenSave", 1f);
    }

    private void Update()
    {
        foreach (GameObject au1 in audiosMusic)
            au1.GetComponent<AudioSource>().volume = music.value;    //Carga en todos los objetos con el tag audio el valor que corresponda.

        foreach (GameObject au2 in characterMusic)
            au2.GetComponent<AudioSource>().volume = character.value;

        foreach (GameObject au3 in enviromentMusic)
            au3.GetComponent<AudioSource>().volume = enviroment.value;
    }

    public void guardarVolumen()
    {
        PlayerPrefs.SetFloat("volumenSave", music.value);     //Guarda la informaci�n cuando cambiamos el slider.
        PlayerPrefs.SetFloat("volumenSave", character.value);
        PlayerPrefs.SetFloat("volumenSave", enviroment.value);
    }

    public void ControlMusic(){
        panelPause.SetActive(false);
        panelMusic.SetActive(true);
    }

    public void ReturnPause(){
        panelPause.SetActive(true);
        panelMusic.SetActive(false);
    }
}

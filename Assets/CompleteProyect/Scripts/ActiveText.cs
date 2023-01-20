using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveText : MonoBehaviour
{
    [SerializeField]private GameObject panel;
    [SerializeField]private GameObject dialogue1,dialogue2,dialogue3;

    public void activeText1()
    {
        dialogue1.SetActive(false);
        dialogue2.SetActive(true);
        dialogue3.SetActive(false);
    }

    public void activeText2()
    {
        dialogue1.SetActive(false);
        dialogue2.SetActive(false);
        dialogue3.SetActive(true);
    }
}

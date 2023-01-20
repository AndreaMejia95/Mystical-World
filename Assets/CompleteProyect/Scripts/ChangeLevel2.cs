using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeLevel2 : MonoBehaviour
{
    public Image barLoading;
    AsyncOperation OpetarionBar; //Loading lever of background

    void Start()
    {
        loadingScena("Level2");
    }


    public void loadingScena(string name)
    {
        StartCoroutine(loadingS(name));
    }

    IEnumerator loadingS(string name)
    {
        OpetarionBar = SceneManager.LoadSceneAsync(name);
        while(!OpetarionBar.isDone)
        {
            barLoading.fillAmount = OpetarionBar.progress;
            yield return null;
        }
    }
}

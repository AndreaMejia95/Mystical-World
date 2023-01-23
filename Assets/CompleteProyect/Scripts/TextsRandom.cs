using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextsRandom : MonoBehaviour
{
    public TextMeshProUGUI tipsTexts;
    public string[]texts;
    public int countText;
    private float spawnDelay = 0.1f;
    private float spawnInterval=0.5f;

    void Start()
    {
        GenerateTips();
        InvokeRepeating("GenerateTips", spawnDelay, spawnInterval);

    }

    private void GenerateTips()
    {
        countText = Random.Range(0,texts.Length);
        tipsTexts.text= texts[countText];
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSatyr : MonoBehaviour
{
    public GameObject enemy;
    public GameObject door;

    public void activeDoor()
    {
        enemy.SetActive(true);
        door.SetActive(true);

        if(enemy == false)
        {
            door.SetActive(false);
        }
    }
}

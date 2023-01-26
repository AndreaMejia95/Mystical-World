using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDoor2 : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        
        if(other.collider.CompareTag("Player")){
            SceneManager.LoadScene("Level2");
        }
    }
}

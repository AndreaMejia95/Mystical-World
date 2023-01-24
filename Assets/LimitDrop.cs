using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LimitDrop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
    }

    private void OnTriggerStay(Collider other) {
        if(other.transform.CompareTag("Player")){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnCollisionEnter(Collision other) {
            if(other.transform.CompareTag("BadWall")){
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
}

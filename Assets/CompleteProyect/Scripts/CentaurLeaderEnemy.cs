using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class CentaurLeaderEnemy : MonoBehaviour
{
    public int lifeEnemyTest;
    public NavMeshAgent enemy;
    public Transform Player;
    public Animator animatorEnemy;
    public bool IsMovingAtack = true;
    public GameObject hammerEnemy;
    public Image lifeEnemy;
    public GameObject doorObject;
    public GameObject textDoor;
    public bool IsDead = false;

    private void Start()
    {
        lifeEnemyTest = 100;
        //  animatorEnemy = gameObject.GetComponent<Animator>();


        foreach (var item in animatorEnemy.parameters)
        {
            Debug.Log(item.name);
        }


    }

    private void Update()
    {

        if(!IsDead){
  float dist = Vector3.Distance(Player.position, transform.position);
        // print(dist);

        if (dist < 6)
        {
            enemy.SetDestination(Player.position);

            animatorEnemy.SetInteger("NumState", 1);


        }

        if (dist < 2)
        {
            animatorEnemy.SetInteger("NumState", 13);

        }

        }
      



    }

    public void changeMovingAtack()
    {
        IsMovingAtack = false;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Sword"))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(7f, 0, 7f), ForceMode.Impulse);
            print(lifeEnemyTest);
            lifeEnemyTest = lifeEnemyTest - 10;
            lifeEnemy.fillAmount -= 10f * Time.deltaTime;
            if (lifeEnemy.fillAmount <= 0)
            {
                IsDead = true;
                animatorEnemy.SetInteger("NumState", 28);
                gameObject.GetComponent<NavMeshAgent>().enabled = false;
                doorObject.GetComponent<BoxCollider>().enabled = true;
                textDoor.SetActive(true);
              
              //  Destroy(gameObject, 3f);
            }

        }

        if (collision.collider.CompareTag("Arrow"))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(7f, 0, 7f), ForceMode.Impulse);
            print(lifeEnemyTest);
            lifeEnemyTest = lifeEnemyTest - 10;
            lifeEnemy.fillAmount -= 10f * Time.deltaTime;

            if (lifeEnemy.fillAmount <= 0)
            {
                IsDead = true;
                gameObject.GetComponent<NavMeshAgent>().enabled = false;

                animatorEnemy.SetInteger("NumState", 28);
                doorObject.GetComponent<BoxCollider>().enabled = true;
             //   Destroy(gameObject, 3f);
            }
        }
    }





}

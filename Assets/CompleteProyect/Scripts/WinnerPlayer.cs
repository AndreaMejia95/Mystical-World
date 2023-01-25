using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinnerPlayer : MonoBehaviour
{
       public Image lifeMinotaur;

    public void MinotaurDead()
    {
        if (lifeMinotaur.fillAmount == 0)
        {
            SceneManager.LoadScene("Winner");
        }
    }
}



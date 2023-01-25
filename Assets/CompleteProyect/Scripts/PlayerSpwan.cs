using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpwan : MonoBehaviour
{
    public Transform player;
    private Transform point;

    // Start is called before the first frame update
    void Start()
    {
        point = GetComponent<Transform>();
        player.position = point.position;
    }

}

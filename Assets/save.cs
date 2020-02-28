using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class save : MonoBehaviour
{
    public GameObject player;
    public float pX = -12.26f;
    public float pY = 1.743913f;
    private void Start()
    {

    }
    private void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            pX = player.transform.position.x;
            pY = player.transform.position.y;
        }
    }
}

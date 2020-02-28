using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sendback : MonoBehaviour
{
    public GameObject player;
    public float xGo = -12.26f;
    public float yGo = 1.743913f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            xGo = other.gameObject.GetComponent<save>().pX;
            yGo = other.gameObject.GetComponent<save>().pY;
            other.gameObject.GetComponent<movement>().counter = 0;
            player = other.gameObject;
            player.transform.position = new Vector2(xGo, yGo);
        }

    }
}

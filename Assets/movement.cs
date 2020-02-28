using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Vector3 move = new Vector3(1f, 0f, 0f);
    public float moveSpeed = 30f;
    public float jForce = 20f;
    public int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("v"))
        {
            if (counter < 1)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jForce), ForceMode2D.Impulse);
                counter = 1;
            } 
        }
        transform.position += move * Time.deltaTime * moveSpeed;
    }
}

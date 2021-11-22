using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{


    public GameObject gameObject;
    public Vector3 direction;

    private void Update()
    {
        transform.Translate(direction * Time.deltaTime);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            direction.z = -1;
        }
        if (collision.gameObject.tag == "Block1")
        {
            direction.z = 1;
        }
       
    }

  
}

        
    
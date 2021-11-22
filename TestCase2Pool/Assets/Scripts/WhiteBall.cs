using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WhiteBall : MonoBehaviour
{

    public Vector3 Startpos;
    public bool ResetIt;
    public GameObject whiteball;
    public Rigidbody rb;
    
    // Use this for initialization
    void Start()
    {
        Startpos = transform.position;
    }

    private void OnCollisionEnter(Collision collision)

    {

        if (collision.gameObject.tag == "shot")
        {

            whiteball.transform.position = Startpos;
            rb.velocity = new Vector3(0, 10, 0);

        }
        if (collision.gameObject.tag == "enemy")
        {
            whiteball.transform.position = Startpos;
            rb.velocity = new Vector3(0, 10, 0);
        }
    }

        // Update is called once per frame
        void Update()
        {

            if (transform.position.y < -0.1f)
            {
                transform.position = new Vector3(0, 0.24f, 0);
                GetComponent<Rigidbody>().velocity = Vector3.zero;
            }

            if (ResetIt)
            {
                ResetIt = false;
                transform.position = Startpos;
                GetComponent<Rigidbody>().velocity = Vector3.zero;
            }

        }
        void ResetBall()
        {
            ResetIt = true;

        }
    
}
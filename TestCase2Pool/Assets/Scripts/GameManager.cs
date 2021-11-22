using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    protected LineRenderer line;
    public WhiteBall whiteball;
    public Text Text;
    protected int Hits = 0;
    public GameObject player;


    // Use this for initialization
    void Start()
    {

        for (int i = 0; i < 1; i++)
        {
            Instantiate(whiteball);
        }

        line = FindObjectOfType<LineRenderer>();
        whiteball = FindObjectOfType<WhiteBall>();
        Text.text = "Hits: " + Hits;
        
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        var direction = Vector3.zero;

        if (Physics.Raycast(ray, out hit))
        {

            var ballPos = new Vector3(whiteball.transform.position.x, 0.1f, whiteball.transform.position.z);
            var mousePos = new Vector3(hit.point.x, 0.1f, hit.point.z);
            //var mousePos = new Vector3(hit.point.x, 0.1f, hit.point.z);
            line.SetPosition(0, mousePos);//player.transform.position);
            line.SetPosition(1, ballPos);
            direction = (mousePos - ballPos).normalized; //player.transform.position

        }

        if (Input.GetMouseButtonDown(0) && line.gameObject.activeSelf)
        {
            Hits++;
            Text.text = "Hits: " + Hits;
            line.gameObject.SetActive(false);
            whiteball.GetComponent<Rigidbody>().velocity = direction * 10f;
        }

        if (!line.gameObject.activeSelf && whiteball.GetComponent<Rigidbody>().velocity.magnitude < 0.3f)
        {

            line.gameObject.SetActive(true);
        }
    }

   
}
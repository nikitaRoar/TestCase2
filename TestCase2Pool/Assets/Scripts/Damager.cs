﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour
{
   

    private void OnCollisionEnter(Collision other)
    {
       


            if (other.gameObject.tag == "Player")
            {
                Destroy(this.gameObject);
            
                
            }
            

    }
   
}
   



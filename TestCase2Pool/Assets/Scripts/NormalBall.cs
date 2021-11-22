﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class NormalBall : MonoBehaviour
    {

        protected Vector3 Startpos;
        protected bool ResetIt;


        void Start()
        {
            Startpos = transform.position;
        }


        void FixedUpdate()
        {

            if (transform.position.y < 0.01f)
                gameObject.SetActive(false);

            if (ResetIt)
            {
                ResetIt = false;
                transform.position = Startpos;
                GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }

        public void ResetBall()
        {
            ResetIt = true;
        }
    }


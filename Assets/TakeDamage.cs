﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "HitBox")
        {
            print(other.name);

            if (other.GetComponentInParent<characterScript>() != null)
            {
                other.GetComponentInParent<characterScript>().Death();

            }
        }


        

    }
}



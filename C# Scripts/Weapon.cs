﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
  
    public Transform FirePoint;
    public GameObject FBPreFab;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }   
    }

    void Shoot()
    {
        Instantiate(FBPreFab, FirePoint.position, FirePoint.rotation); /*Shooting Logic*/
    }

}

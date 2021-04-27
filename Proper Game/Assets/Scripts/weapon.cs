﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public GameObject bulletprefab;
    public Transform firepoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
    }

    private void shoot()
    {
        Instantiate(bulletprefab, firepoint.position, firepoint.rotation);
    }
}

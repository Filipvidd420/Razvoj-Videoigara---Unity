﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Kretanje>().jump = false;
        }
    }
}

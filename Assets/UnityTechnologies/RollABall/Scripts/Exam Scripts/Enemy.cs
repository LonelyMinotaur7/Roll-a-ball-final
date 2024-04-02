using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    [SerializeField] float Speed = 0.1f;

    public Transform target;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!PlayerController.playing)
        {
            return;
        }
        
        
        transform.LookAt(target);

        transform.position += Speed * 0.01f * transform.forward;
    }


    
}

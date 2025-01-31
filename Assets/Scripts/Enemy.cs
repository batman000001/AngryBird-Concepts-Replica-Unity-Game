﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 4f;
    public GameObject deathEffect;
    public static int enemiesAlive = 0;

    void  Start(){
        enemiesAlive++;
    }

    void OnCollisionEnter2D(Collision2D colInfo)
    {
        if(colInfo.relativeVelocity.magnitude > health ){
            Die();
        }
    }


    void Die(){
        Instantiate(deathEffect, transform.position, Quaternion.identity); 

        enemiesAlive --;
        if(enemiesAlive <= 0){
            Debug.Log("Level Won");
        }
        Destroy(gameObject);
    }
}

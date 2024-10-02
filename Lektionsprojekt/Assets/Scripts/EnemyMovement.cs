using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyMovement : MonoBehaviour
{
    //Attribut
    protected int speed;
    public float damage;

    

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    protected abstract void Move();
}

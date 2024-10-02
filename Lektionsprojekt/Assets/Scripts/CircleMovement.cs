using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMovement : EnemyMovement
{
    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        damage = 15;
        float x;
        float y;
        while (true)
        {
            x = UnityEngine.Random.Range(-1f, 1f) * speed;
            y = UnityEngine.Random.Range(-1f, 1f) * speed;

            if (Math.Abs(x) > 0.25 || Math.Abs(y) > 0.25)
            {
                break;
            }
        }



        direction = new Vector3(x, y, 0);
    }

    protected override void Move()
    {
        transform.position += direction * Time.deltaTime;

        if (Math.Abs(transform.position.y) > 5)
        {
            direction = new Vector3(direction.x, -direction.y, 0);
        }

        if (Math.Abs(transform.position.x) > 9)
        {
            direction = new Vector3(-direction.x, direction.y, 0);
        }
    }
}

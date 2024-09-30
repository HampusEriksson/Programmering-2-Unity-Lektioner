using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaMovement : EnemyMovement
{
    private int direction;
    // Start is called before the first frame update
    void Start()
    {
        speed = 3;
        direction = 1;
    }

    

    protected override void Move()
    {
        float x_move = speed * direction * Time.deltaTime;
        transform.Translate(x_move, 0, 0);

        if (Mathf.Abs(transform.position.x) > 9)
        {
            direction *= -1;
        }
    }
}

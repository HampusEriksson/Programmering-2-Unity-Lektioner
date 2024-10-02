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
        if (Random.Range(0f,1f) < 0.5f)
        {
            direction = 1;
        }
        else
        {
            direction = -1;
        }
        
        damage = Random.Range(3f, 8f);
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

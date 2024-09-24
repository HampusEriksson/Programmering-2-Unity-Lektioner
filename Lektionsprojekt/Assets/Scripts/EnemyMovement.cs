using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //Attribut
    private int speed = 5;
    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        float x;
        float y;
        while (true){
             x = UnityEngine.Random.Range(-1f, 1f) * speed;
             y = UnityEngine.Random.Range(-1f, 1f) * speed;

            if(Math.Abs(x)>0.25 || Math.Abs(y)>0.25)
            {
                break;
            }
        }
        


        direction = new Vector3(x, y, 0);   
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * Time.deltaTime;   

        if(Math.Abs(transform.position.y) > 5)
        {
            direction = new Vector3(direction.x, -direction.y, 0);
        }

        if (Math.Abs(transform.position.x) > 9)
        {
            direction = new Vector3(-direction.x, direction.y, 0);
        }
    }
}

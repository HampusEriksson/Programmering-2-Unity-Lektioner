using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Attribut
    private int speed = 7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Input.GetAxis har ett värde mellan 1f och -1f
        float x_direction = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float y_direction = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(x_direction, y_direction, 0);   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("GAME OVER!");
        speed = 0;
    }
}

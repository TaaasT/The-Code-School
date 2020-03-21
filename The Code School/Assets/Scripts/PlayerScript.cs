using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 10f;
    float minX = -2.55f;
    float maxX = 2.55f;


    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float h = Input.GetAxis("Horizontal");
        Vector2 currentPos = transform.position;

        if (h > 0)
        {
            currentPos.x += speed * Time.deltaTime;
        }
        else if(h < 0)
        {
            currentPos.x -= speed * Time.deltaTime;
        }

        if(currentPos.x < minX)
        {
            currentPos.x = minX;
        }
        if (currentPos.x > maxX)
        {
            currentPos.x = maxX;
        }
        transform.position = currentPos;
    }
}

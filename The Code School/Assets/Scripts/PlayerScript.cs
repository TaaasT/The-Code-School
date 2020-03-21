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

        currentPos.x = Mathf.Clamp(currentPos.x, minX, maxX);

        transform.position = currentPos;
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Bomb")
        {
            Time.timeScale = 0f;
        }
    }

}

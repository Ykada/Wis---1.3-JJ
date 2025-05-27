using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Vector3 direction = new Vector3(1, 2, 0);
    Vector2 min, max;
    float speed = 3;
    Vector3 velocity;
    void Start()
    {
        direction = direction.normalized;
        min = Camera.main.ScreenToWorldPoint(Vector2.zero); max = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }
    void Update()
    {
        velocity = direction * speed * Time.deltaTime;
        transform.position += velocity;

        if (transform.position.x + transform.localScale.x / 2 > max.x)
        {
            direction.x = -direction.x;
        }
        if (transform.position.x - transform.localScale.x / 2 < min.x)
        {
            direction.x = -direction.x;
        }
        if (transform.position.y + transform.localScale.y / 2 > max.y)
        {
            direction.y = -direction.y;
        }
        if (transform.position.y - transform.localScale.y / 2 < min.y)
        {
            direction.y = -direction.y;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncingball : MonoBehaviour
{
    GameObject ball;

    public float speed = 5f;

    Camera cam;
    Vector2 minscreen, maxscreen;
    Vector2 direction;
    void Start()
    {
        cam = Camera.main;
        minscreen = cam.ScreenToWorldPoint(Vector2.zero);
        maxscreen = cam.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        ball = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        ball.transform.position = Vector3.zero;
        direction = new Vector2(1, 1).normalized;
    }
    void Update()
    {
        ball.transform.Translate(direction * speed * Time.deltaTime);
        Vector2 pos = ball.transform.position;
        if (pos.x < minscreen.x || pos.x > maxscreen.x)
        {
            direction.x = -direction.x;
        }
        if (pos.y < minscreen.y || pos.y > maxscreen.y)
        {
            direction.y = -direction.y;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balmovement : MonoBehaviour
{
    public float speed = 3;
    public GameObject ball;
    public GameObject point1;
    public GameObject point2;
    private Vector3 direction;
    private Vector3 position;
    void Start()
    {
        position = ball.transform.position;
        direction = (point2.transform.position - point1.transform.position).normalized;
    }
    void Update()
    {
        position += direction * speed * Time.deltaTime;
        ball.transform.position = position;

        if (Vector3.Distance(position, point2.transform.position) < 0.1f)
        {
            direction = (point1.transform.position - point2.transform.position).normalized;
        }
        else if (Vector3.Distance(position, point1.transform.position) < 0.1f)
        {
            direction = (point2.transform.position - point1.transform.position).normalized;
        }
    }
}

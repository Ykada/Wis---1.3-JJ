using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpingblock : MonoBehaviour
{
    [SerializeField] private Transform block;
    [SerializeField] private Vector3 accelerationbegin;
    [SerializeField] private Vector3 velocitybegin;


    private Vector3 acceleration;
    private Vector3 velocity;

    enum State { Falling, Jumping };
    private State mystate = State.Falling;

    float ymin;

    private void Start()
    {
        velocity = velocitybegin;
        acceleration = accelerationbegin;

        ymin = block.position.y;
    }

    private void Update()
    {
        if (mystate == State.Falling) {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                velocity.y = 1f;
                mystate = State.Jumping;
                Debug.Log("Jumping");
            }
        }
        if (mystate == State.Jumping)
        {
            if (block.position.y <= ymin)
            {
                mystate = State.Falling;
                velocity = Vector3.zero;
                acceleration = Vector3.zero;
                block.position = new Vector3(block.position.x, ymin, block.position.z);
            }    
        }

        velocity += acceleration * Time.deltaTime;
        block.position += velocity * Time.deltaTime;
        if (block.position.y < 0)
        {
            Vector3 pos = block.position;
            pos.y = 0;
            block.position = pos;
            velocity.y = -velocity.y * 0.8f;
        }
    }

}

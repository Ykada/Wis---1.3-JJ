using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parabola : MonoBehaviour
{
    [SerializeField] point point;
    private int numberofpoints = 10;
    Vector2 minscreen, maxscreen;
    

    private void Start()
    {
        minscreen = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        maxscreen = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        float dx = (maxscreen.x - minscreen.x) / numberofpoints;

        for (int i = 0; i < numberofpoints; i++)
        {
            float x_pos = minscreen.x + i * dx;
            point copyofpoint = Instantiate(point);
            copyofpoint.transform.position = new Vector3(x_pos, 0, 0);
        }
    }


}

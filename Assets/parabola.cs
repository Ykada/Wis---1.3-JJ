using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parabola : MonoBehaviour
{
    [SerializeField] private point pointPrefab;
    private int numberOfPoints = 10;
    private Vector2 minscreen, maxscreen;

    private QuadetricFunction f;
    [SerializeField] public float a = 1;
    [SerializeField] public float b = 1;
    [SerializeField] public float c = 1;

    private void Start()
    {
        UpdateParabola();
    }

    private void OnValidate()
    {
        if (Application.isPlaying)
        {
            UpdateParabola();
        }
    }

    private void UpdateParabola()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        minscreen = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        maxscreen = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        float dx = (maxscreen.x - minscreen.x) / numberOfPoints;

        f = new QuadetricFunction(a, b, c);

        for (int i = 0; i < numberOfPoints; i++)
        {
            float x_pos = minscreen.x + i * dx;
            float y_pos = f.gety(x_pos);

            point copy = Instantiate(pointPrefab, transform);
            copy.transform.position = new Vector3(x_pos, y_pos, 0);
        }
    }
}

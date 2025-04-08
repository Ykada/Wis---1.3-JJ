using System;
using UnityEngine;

public class ColorMap : MonoBehaviour
{
    [SerializeField]
    private GameObject[] grid = new GameObject[42];
    public float waitTime = 0.3f;
    private float hue = 0f;
    private float hueIncrement = 0.1f;

    void Start()
    {
        InvokeRepeating("ChangeColors", 0f, waitTime);
    }

    void ChangeColors()
    {
        for (int i = 0; i < grid.Length; i++)
        {
            if (grid[i] != null)
            {
                var spriteRenderer = grid[i].GetComponent<SpriteRenderer>();
                if (spriteRenderer != null)
                {
                    spriteRenderer.color = GetRainbowColor();
                }
            }
        }
    }

    Color GetRainbowColor()
    {
        Color rainbowColor = Color.HSVToRGB(hue, 1f, 1f);
        hue += hueIncrement;
        if (hue > 1f)
        {
            hue = 0f;
        }

        return rainbowColor;
    }
}
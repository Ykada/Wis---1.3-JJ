using System;
using UnityEngine;

public class ColorMap : MonoBehaviour
{
    [SerializeField]
    private GameObject[] grid = new GameObject[42];  // 6 rows * 7 columns = 42 elements
    public float waitTime = 0.3f;
    private float hue = 0f;  // Start from the beginning of the rainbow
    private float hueIncrement = 0.1f;  // How fast the rainbow progresses

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
        // Generate a color based on the current hue
        Color rainbowColor = Color.HSVToRGB(hue, 1f, 1f); // Full saturation and brightness
        hue += hueIncrement;

        // Ensure the hue wraps around when it exceeds 1
        if (hue > 1f)
        {
            hue = 0f;
        }

        return rainbowColor;
    }
}
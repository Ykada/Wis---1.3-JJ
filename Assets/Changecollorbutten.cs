using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bit : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public bool state;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (state)
        {
            // Zet de sprite kleur op groen als state true is
            spriteRenderer.color = Color.green;
        }
        else
        {
            // Zet de sprite kleur op rood als state false is
            spriteRenderer.color = Color.red;
        }
    }
    private void OnMouseUp()
    {
        state = !state; // Wissel tussen true en false
    }
}

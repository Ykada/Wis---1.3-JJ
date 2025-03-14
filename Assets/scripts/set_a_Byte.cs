using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAByte : MonoBehaviour
{
    [SerializeField] private int value = 0;

    public GameObject bit1, bit2, bit3, bit4, bit5, bit6, bit7;
    private GameObject[] bits;

    void Start()
    {
        bits = new GameObject[] { bit1, bit2, bit3, bit4, bit5, bit6, bit7 };
        UpdateBits();
    }

    void Update()
    {
        UpdateBits();
    }

    private void UpdateBits()
    {
        for (int i = 0; i < bits.Length; i++)
        {
            SpriteRenderer bitSpriteRenderer = bits[i].GetComponent<SpriteRenderer>();

            if ((value & (1 << i)) != 0)
            {
                bitSpriteRenderer.color = Color.green;
            }
            else
            {
                bitSpriteRenderer.color = Color.red;
            }
        }
    }

    public void SetValue(int newValue)
    {
        value = Mathf.Clamp(newValue, 0, 127);
        UpdateBits();
    }

    private void ToggleBit(int bitIndex)
    {
        value ^= (1 << bitIndex); 
        UpdateBits();
        // Ja dit script is zelf geschreven \\
    }
}

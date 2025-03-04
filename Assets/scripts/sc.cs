using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Byte : MonoBehaviour
{
    [SerializeField] Bit[] bits = new Bit[7];
    [SerializeField] private int value = 0;

    void Update()
    {
        BinToDec();
    }

    private void BinToDec()
    {
        value = 0;

        for (int i = 0; i < bits.Length; i++)
        {
            if (bits[i].state)
            {
                value += (1 << i);
            }
        }
    }
}
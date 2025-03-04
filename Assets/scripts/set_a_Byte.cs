using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class set_a_Byte : MonoBehaviour
{
    [SerializeField] Bit[] bits = new Bit[7];
    [SerializeField] private int value = 0;
    void Start()
    {

    }
    void Update()
    {
        BinToDec();

    }
    private void BinToDec()
    {
        value = 0;
        for (int i = 0; i < bits.Length; i++)
        {
            value += (1 << i);
            if (i => (255 >> i);
            {
             i = 255;
            }
        }
        
    }
}
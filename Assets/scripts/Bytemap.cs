using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bytemap : MonoBehaviour
{
    public GameObject[] Bytelist;
    [SerializeField] private int value1 = 0;
    [SerializeField] private int value2 = 0;
    [SerializeField] private int value3 = 0;
    [SerializeField] private int value4 = 0;
    [SerializeField] private int value5 = 0;
    [SerializeField] private int value6 = 0;
    void Start()
    {
        List<GameObject> list = new List<GameObject>();
         Update();
    }  
    void Update()
    { 
    }
    public void SetValue(int newValue)
    {
        value1 = Mathf.Clamp(newValue, 0, 127);
    }
}

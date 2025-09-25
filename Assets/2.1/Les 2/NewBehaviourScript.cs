using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadetricFunction
{
    public float a = 1;
    public float b = 1;
    public float c = 1;

    public QuadetricFunction(float a, float b, float c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public float gety(float x)
    {
        return a * x * x + b * x + c;
    }
}

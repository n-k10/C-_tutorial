using System;
using UnityEngine;

public class Car : MonoBehaviour
{
    private string color;
    private int speed;

    public void SetColor(string newColor)
    {
        color = newColor;
    }

    public void SetSpeed(int newSpeed)
    {
        speed = newSpeed;
    }

    void Start()
    {
        SetColor("Red");
        SetSpeed(100);
        Debug.Log("Car color is " + color + " and it is moving at " + speed + " km/h.");
    }
}

using System;
using UnityEngine;

public class Car : MonoBehaviour
{
    private string color;
    private int speed;

    // SetColorメソッドは、外部からカラーを設定するためのパブリックメソッドです。
    // 引数newColorを使用して、クラスのプライベート変数colorに値を設定します。
    public void SetColor(string newColor)
    {
        color = newColor;
    }
    
    // SetSpeedメソッドは、外部からスピードを設定するためのパブリックメソッドです。
    // 引数newSpeedを使用して、クラスのプライベート変数speedに値を設定します。
    public void SetSpeed(int newSpeed)
    {
        speed = newSpeed;
    }

    void Start()
    {
        SetColor("Red");　// SetColorを呼び出して色を"Red"に設定します。
        SetSpeed(100);　// SetSpeedを呼び出してスピードを100に設定します。
        Debug.Log("Car color is " + color + " and it is moving at " + speed + " km/h.");
    }
}

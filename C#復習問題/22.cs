using UnityEngine;

public class Car : MonoBehaviour
{
    private string color;
    private int speed;

    public void SetColor(string color)
    {
        this.color = color;
    }

    public void SetSpeed(int speed)
    {
        this.speed = speed;
    }

    public void DisplayDetails()
    {
        Debug.Log("Color: " + color + ", Speed: " + speed + " km/h");
    }

    void Start()
    {
        Car myCar = new Car();
        myCar.SetColor("Red");
        myCar.SetSpeed(100);
        myCar.DisplayDetails();
    }
}

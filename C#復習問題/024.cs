using UnityEngine;

public class VectorTest : MonoBehaviour
{
    void Start()
    {
        Vector2 vector1 = new Vector2(5, 3);
        Vector2 vector2 = new Vector2(2, 1);
        Vector2 result = vector1 - vector2;
        Debug.Log("Resulting Vector after subtraction: " + result);
    }
}

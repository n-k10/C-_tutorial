using UnityEngine;

public class VectorTest : MonoBehaviour
{
    void Start()
    {
        Vector3 vector = new Vector3(1, 2, 3);
        float magnitude = vector.magnitude;
        Debug.Log("Magnitude of Vector: " + magnitude);
    }
}

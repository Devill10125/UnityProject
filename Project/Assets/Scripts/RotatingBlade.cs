using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 100f;
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
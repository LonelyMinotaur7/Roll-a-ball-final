using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 rotationAxis = Vector3.up; // Default rotation axis is around the y-axis
    public float rotationSpeed = 50f; // Rotation speed in degrees per second

    void Update()
    {
        // Rotate the object continuously around the specified axis
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
    }
}

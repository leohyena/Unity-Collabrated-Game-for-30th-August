using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Action : MonoBehaviour
{
    public float rotationSpeed = 20.0f; // Dönme hızı

    void Update()
    {
        // Fare pozisyonunu al
        float mouseX = Input.GetAxis("Mouse X");

        // Karakteri yatay eksende daha hızlı döndürme
        transform.Rotate(Vector3.up, mouseX * rotationSpeed * Time.deltaTime);
    }
}

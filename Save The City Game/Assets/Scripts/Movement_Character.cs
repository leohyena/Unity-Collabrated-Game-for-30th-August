using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Character : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        Vector3 playerInput = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Jump"), Input.GetAxis("Vertical"));
        Vector3 speed_of_movement = playerInput * Time.deltaTime * speed;
        transform.Translate(speed_of_movement);
    }
}
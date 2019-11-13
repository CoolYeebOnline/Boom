using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    void Update()
    {
        Vector3 euler = transform.rotation.eulerAngles;
        euler.x += Input.GetAxis("Vertical");
        euler.y -= Input.GetAxis("Horizontal");
        transform.rotation = Quaternion.Euler(euler);
    }
}

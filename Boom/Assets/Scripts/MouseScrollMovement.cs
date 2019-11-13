using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScrollMovement : MonoBehaviour
{
  
    void Update()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z + Input.mouseScrollDelta.y);
    }
}

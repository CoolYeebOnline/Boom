using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBombPlacement : MonoBehaviour
{
    public GameObject bombPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePositionWithZOffset = Input.mousePosition;
            mousePositionWithZOffset.z = 10;

            Vector3 cameraPosition = Camera.main.transform.position;

            Vector3 mousePositionInWorldSpace = Camera.main.ScreenToWorldPoint(mousePositionWithZOffset);

            Vector3 directionFromCameraToMouse = mousePositionInWorldSpace - cameraPosition;

            RaycastHit hitInfo;
            if (Physics.Raycast(new Ray(cameraPosition, directionFromCameraToMouse), out hitInfo, Mathf.Infinity)){
                GameObject bombInstance = Instantiate(bombPrefab);

                bombInstance.transform.parent = hitInfo.collider.transform;

                bombInstance.transform.position = hitInfo.point;

                bombInstance.transform.localRotation = Quaternion.identity;

                bombInstance.transform.localScale = Vector3.one;

                Vector3 trueScale = bombInstance.transform.lossyScale;

                bombInstance.transform.localScale = new Vector3(1 / trueScale.x, 1 / trueScale.y, 1 / trueScale.z);

                bombInstance.GetComponent<bomb>().LightFuse();

            }
        }
    }
}

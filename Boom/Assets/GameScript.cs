using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    public string importantTag = "Important";
    private int importantCount = 0;

    void Update()
    {
        if (importantCount == 0)
        {

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "important")
        {
            importantCount++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == importantTag)
        {
            importantCount--;
        }
    }

    public void OnGUI()
    {
        GUI.color = Color.black;

        GUI.Label(new Rect(0, 0, 200, 100), "Remaining" + importantCount);
    }
}

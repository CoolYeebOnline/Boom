using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundIslandsSpawner : MonoBehaviour
{
    [SerializeField]
    private int width = 1000;

    [SerializeField]
    private int height = 1000;

    [SerializeField]
    private int depth = 1000;

    [SerializeField]
    private GameObject islandPrefab;

    [SerializeField]
    private int islandsAmount = 100;
       


    void Start()
    {
        for (int i = 0; i < islandsAmount; i++)
        {
            GameObject instance = Instantiate(islandPrefab);
            instance.transform.parent = transform;
            instance.transform.position = RandomPosition();
            instance.transform.localScale = Vector3.one * Random.Range(5, 10);

            instance.transform.rotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
        }
    }

    private Vector3 RandomPosition()
    {
        return new Vector3(Random.Range(-width, width),
            Random.Range(height - height, height),
            Random.Range(-depth, depth)
            );
    }
}

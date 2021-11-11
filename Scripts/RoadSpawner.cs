using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    public GameObject[] roads;
    public GameObject block;

    public float blockIndex, roadIndex=1;

    public void MakeRoad()
    {
        int n = Random.Range(0, roads.Length);
        Vector3 newPos = new Vector3(roadIndex * 100 - 100, 0f, 0f);

        GameObject newRod = Instantiate(roads[n], newPos, roads[n].transform.rotation);

        for (int i = 0; i < 10; i++)
        {
            SpawnBlock();

        }
        roadIndex++;
    }

    private void SpawnBlock()
    {
        Vector3 newPos = new Vector3(Random.Range(blockIndex * 10 - 20, blockIndex * 10 - 10), 1f, Random.Range(-1, 1));

        GameObject newBlock = Instantiate(block, newPos, Quaternion.identity);
        blockIndex++;
    }
}

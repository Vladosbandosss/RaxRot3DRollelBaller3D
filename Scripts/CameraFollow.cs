using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private GameObject player;

    public float ofset = 3f;

    private void Awake()
    {
        player = GameObject.FindWithTag("Player");
    }

    private void FixedUpdate()
    {
        Vector3 temp = transform.position;
        temp.x = player.transform.position.x-ofset;
        transform.position = temp;
    }
}

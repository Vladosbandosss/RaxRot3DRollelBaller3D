using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Road" || other.tag == "Cube")
        {
            other.gameObject.SetActive(false);
        }
    }
}

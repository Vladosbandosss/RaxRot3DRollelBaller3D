using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    Text text;
    private int meters;

    private void Start()
    {
        text = GameObject.Find("sc").GetComponent<Text>();
        StartCoroutine(nameof(CountScore));
    }

    IEnumerator CountScore()
    {
        yield return new WaitForSeconds(0.3f);
        meters++;
        text.text = meters.ToString() + " m";

        StartCoroutine(nameof(CountScore));
    }
}

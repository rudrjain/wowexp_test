using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class augment : MonoBehaviour
{
    public GameObject canvas;

    private void Awake()
    {
        canvas = GameObject.FindGameObjectWithTag("Canvas");
        canvas.SetActive(false);
    }

    private void OnDestroy()
    {
        canvas.SetActive(true);
    }
}

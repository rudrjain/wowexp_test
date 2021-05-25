using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class cube : MonoBehaviour
{
    public TextMeshPro tapCounter;

    public int counter = 0;
    public GameObject banner;

    public void OnMouseDown()
    {
        banner.SetActive(true);
        counter++;
        tapCounter.text = "You Tapped The Cube : " + counter.ToString() + " Times";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube1 : MonoBehaviour
{
    public Material mat,mat1;
    public Material[] col = new Material[5];
    private int count = -1;
    public AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        mat.CopyPropertiesFromMaterial(mat1);
        for(int i=0;i<5;i++)
        {
            col[i].color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }
        ChangeColor();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        ChangeColor();
        sound.Play();
    }
    public void ChangeColor()
    {
        int temp = Random.Range(0, 100);
        temp = temp % 5;
        if(temp!=count)
        {
            if(temp<5 && temp>-1)
            {
                count = temp;
                mat.CopyPropertiesFromMaterial(col[temp]);
            }
            else
            {
                ChangeColor();
            }
            
        }
        else
        {
            ChangeColor();
        }
    }
}

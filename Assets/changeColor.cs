using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GetComponent<Renderer>().material.color = GetRandomColor();
        }
    }

    private Color GetRandomColor()
    {
        return new Color(Random.Range(0, 1f),
            Random.Range(0, 1f),
            Random.Range(0, 1f));
    }
}

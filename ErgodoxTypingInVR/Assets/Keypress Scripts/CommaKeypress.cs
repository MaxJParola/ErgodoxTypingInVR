using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class CommaKeypress : MonoBehaviour
{
    public Material[] material;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Comma))
        {
            rend.sharedMaterial = material[1];
        }
        if (Input.GetKeyUp(KeyCode.Comma))
        {
            rend.sharedMaterial = material[0];
        }
    }
}
﻿using UnityEngine;
using System.Collections;

public class OneKeypress : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            rend.sharedMaterial = material[1];
        }
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            rend.sharedMaterial = material[0];
        }
    }
}
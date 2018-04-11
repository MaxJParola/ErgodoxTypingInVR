using UnityEngine;
using System.Collections;

public class UKeypress : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.U))
        {
            rend.sharedMaterial = material[1];
        }
        if (Input.GetKeyUp(KeyCode.U))
        {
            rend.sharedMaterial = material[0];
        }
    }
}
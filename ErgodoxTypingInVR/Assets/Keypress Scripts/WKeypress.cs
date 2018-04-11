using UnityEngine;
using System.Collections;

public class WKeypress : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.W))
        {
            rend.sharedMaterial = material[1];
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            rend.sharedMaterial = material[0];
        }
    }
}
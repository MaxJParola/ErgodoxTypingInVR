using UnityEngine;
using System.Collections;

public class qkey : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            gameObject.SetActive(true);
            Debug.Log("Space key was pressed.");

        if (Input.GetKeyUp(KeyCode.Q))
            gameObject.SetActive(false);
            Debug.Log("Space key was released.");
    }
}

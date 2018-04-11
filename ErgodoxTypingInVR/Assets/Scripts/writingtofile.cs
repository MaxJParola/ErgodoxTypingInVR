using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class writingtofile : MonoBehaviour {
    public Text textinput;

    void OnApplicationQuit()
    {
        System.IO.File.AppendAllText("E:\\Unity\\Projects\\Oculus_Dev\\Assets\\Resources\\text.txt", (textinput.text));
    }

}

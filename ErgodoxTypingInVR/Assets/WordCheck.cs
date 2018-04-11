using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;


public class WordCheck : MonoBehaviour {
	public Text thePrompt;
	public InputField iField;
	public string[] textCycle;
	public Color inputColor;
	public Text inputText;
	private int index;
	public GameObject inputAndPromptCanvas;
	public Text endMessage;
	private float timer;
	public Text timerText;
	private bool startTrigger;
	public GameObject endMessageCanvas;
	private float startTime;
	private List<string> finishArray;
	//private bool endState;
	private bool allDone;
	private List<float> wpm;
	private int firstkeypress;
	private float wpmCalc;
	private float wpmAvg;
	private float starter;
	private float totalTime;

	// Use this for initialization
	void Start () {
		index = 0; //used for iterating through the prompts when the right input is put in
		thePrompt.text = textCycle[index]; //initialize the prompt text
		finishArray = new List<string>(); //initialize the list
		wpm = new List<float>();
		startTime = Time.time; //will just initialize to zero since it culls at start frame
		endMessageCanvas.GetComponent<Canvas> ().enabled = false;
		startTrigger = false;
		//endState = false;
		allDone = false;
		firstkeypress = 0;
		wpmCalc = 0;
		wpmAvg = 0;
		starter = 0;
	}

	// Update is called once per frame
	void Update () 
	{
		thePrompt.text = textCycle[index];
		if (allDone == false) 
		{
			if (iField.text == thePrompt.text) 
			{ 
				//Debug.Log ("thePrompt and iField are equal");//primary check
				inputText.color = Color.blue;
				finishArray.Add (timerText.text);
				float finishTime = (Time.time - startTime);
				wpmCalc = ((thePrompt.text.Length / 5f) / (finishTime/60f));
				wpm.Add (wpmCalc);
				Debug.Log (finishTime);
				Debug.Log (thePrompt.text.Length);
				Debug.Log (wpmCalc);
				startTimefunc ();
				timerText.text = "0:0";
				startTrigger = false; //reset so timer wont start until the next 
				if (index < textCycle.Length - 1) //used to stop an outofrange error
				{ 
					index += 1;
					inputText.color = Color.black;
					iField.text = ""; //Reset the input field text
				} 

				else 
				{ 
					endmessages();
					inputAndPromptCanvas.GetComponent<Canvas> ().enabled = false;
					endMessageCanvas.GetComponent<Canvas> ().enabled = true;
					allDone = true;
				}
			} 

			else if (thePrompt.text.Length - 1 < iField.text.Length) 
			{
				inputText.color = Color.red;
			} 

			else 
			{
				inputText.color = Color.black;
			}

			if (Input.anyKeyDown) 
			{
				startTrigger = true;
				firstkeypress +=1;
			}

			if (startTrigger == true) 
			{
				timer = (Time.time - startTime);
				string minutes = ((int)timer / 60).ToString ();
				string seconds = (timer % 60).ToString ("f0");
				timerText.text = minutes + ":" + seconds;
			}

			if (firstkeypress == 1)
			{
				firstkeypressfunc();
			}
			//Debug.Log (iField.text);
			//Debug.Log (thePrompt.text);
			//Debug.Log (index);
			//Debug.Log (textCycle);
			//Debug.Log (textCycle.Length);
		}
	}

	void firstkeypressfunc()
	{
		startTime = Time.time;
		starter = Time.time;
	}

	void startTimefunc()
		{
		startTime = Time.time;
		}

	void endmessages()
	{
		for (int i = 0; i < wpm.Count; i++) 
		{
			wpmAvg += wpm[i];
		}
		wpmAvg = (wpmAvg / wpm.Count);
		totalTime = (Time.time - starter);
		//string wpmAvgString = Convert.ToString(;
		//string totalTimeString = totalTime.ToString;
		endMessage.text = "Thank you for participating! \r\n" + " Total time: " + Convert.ToString(totalTime) + "\r\n WPM: " + Convert.ToString(wpmAvg);
		//endMessage.text = 
		//endState = false;
		//for (int i = 0; i < textCycle.Length; i++) 
		//{
		//	string promptNumber = (i + 1).ToString ();
		//	endMessage.text += "Prompt " + promptNumber +  "\r\n" + "    Time: " + finishArray[i] + "\r\n" + "    WPM: " + wpm[i] + "\r\n";
	}
}
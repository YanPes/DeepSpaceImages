using UnityEngine;
using System.Collections;

public class CaptureScreenshot : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown("1")) 
		{
			Application.CaptureScreenshot("Startfield_1_Perspective.png", 2);
			Debug.Log ("1");
		}
		if (Input.GetKeyDown("2")) 
		{
			Application.CaptureScreenshot("Startfield_2_Perspective.png", 2);
			Debug.Log ("2");
		}
		if (Input.GetKeyDown("3")) 
		{
			Application.CaptureScreenshot("Startfield_3_Perspective.png", 2);
			Debug.Log ("3");
		}
		if (Input.GetKeyDown("4")) 
		{
			Application.CaptureScreenshot("Startfield_4_Perspective.png", 2);
			Debug.Log ("4");
		}
		if (Input.GetKeyDown("5")) 
		{
			Application.CaptureScreenshot("Startfield_5_Perspective.png", 2);
			Debug.Log ("5");
		}
		if (Input.GetKeyDown("6")) 
		{
			Application.CaptureScreenshot("Startfield_6_Perspective.png", 2);
			Debug.Log ("6");
		}
		if (Input.GetKeyDown("7")) 
		{
			Application.CaptureScreenshot("Startfield_7_Perspective.png", 2);
			Debug.Log ("7");
		}
		if (Input.GetKeyDown("8")) 
		{
			Application.CaptureScreenshot("Startfield_8_Perspective.png", 2);
			Debug.Log ("8");
		}
		if (Input.GetKeyDown("9")) 
		{
			Application.CaptureScreenshot("Startfield_9_Perspective.png", 2);
			Debug.Log ("9");
		}
		if (Input.GetKeyDown("0")) 
		{
			Application.CaptureScreenshot("Startfield_10_Perspective.png", 2);
			Debug.Log ("0");
		}
	}
}
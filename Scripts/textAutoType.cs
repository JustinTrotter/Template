using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class textAutoType : MonoBehaviour {

	public float letterPause = 0.2f;
	public float sentancePause = 10f;

	private GUIText text;
	private string message;

	// Use this for initialization
	void Start () {
		message = GetComponent<Text>().text;
		GetComponent<Text>().text = "";
		StartCoroutine (TypeText ());		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator TypeText(){
		foreach (char letter in message.ToCharArray()) {
			GetComponent<Text> ().text += letter;
			if (GetComponent<AudioSource>() && letter != ' ') {
				GetComponent<AudioSource>().PlayOneShot (GetComponent<AudioSource>().clip);
				if (letter == '.')
					yield return new WaitForSeconds (letterPause * sentancePause);
				else
					yield return 0;
			}
			yield return new WaitForSeconds (letterPause);
		}
	}
}

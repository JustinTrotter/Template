using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class textAutoType : MonoBehaviour {
	
	private string message;
	private Text text;
	private AudioSource audio;
	private bool speaking;

	public float letterPause = 0.1f;
	public float sentancePause = 50f;

	void Awake() {
		text = GetComponent<Text>();
		audio = GetComponent<AudioSource>();
	}

	// Use this for initialization
	void Start () {
		message = text.text;
		speakMessage (message, true);	
	}

	// Update is called once per frame
	void Update () {
	
	}

	public void speakMessage(string msg, bool clear){
		if (clear)
			text.text = "";
		StartCoroutine (TypeText (msg, letterPause, sentancePause));
	}

	IEnumerator TypeText(string msg, float letPause, float senPause){
		speaking = true;
		foreach (char letter in msg.ToCharArray()) {
			text.text += letter;
			if (audio && letter != ' ') {
				audio.PlayOneShot (audio.clip);
				if (letter == '.' || letter == ',' || letter == '!' || letter == '?' || letter == ';') {
					speaking = false;
					yield return new WaitForSeconds (letPause * senPause);
				} else {
					speaking = true;
					yield return 0;
				}
			}
			yield return new WaitForSeconds (letPause);
		}
		speaking = false;
	}

	public bool getSpeaking(){
		return speaking;
	}
}

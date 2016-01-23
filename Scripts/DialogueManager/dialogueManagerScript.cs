using UnityEngine;
using System.Collections;
using System;

public class dialogueManagerScript : MonoBehaviour {

	//Portraits
	private GameObject toriel_face_Portrait;
	private GameObject toriel_body_Portrait;
	private GameObject papyrus_face_Portrait;
	private GameObject sans_face_Portrait;

	//Voices
	private AudioClip toriel_Voice;
	private AudioClip papyrus_Voice;
	private AudioClip sans_Voice;

	private GameObject current_face_Portrait;
	private GameObject current_body_Portrait;



	void Awake () {
		//Load Portraits
		toriel_face_Portrait = Resources.Load ("Portraits/Dialogue_Portrait_Toriel_Face") as GameObject;
		toriel_body_Portrait = Resources.Load ("Portraits/Dialogue_Portrait_Toriel_Body") as GameObject;
		papyrus_face_Portrait = Resources.Load ("Portraits/Dialogue_Portrait_Papyrus_Face") as GameObject;
		sans_face_Portrait = Resources.Load ("Portraits/Dialogue_Portrait_Sans_Face") as GameObject;

		//Load Voices
		toriel_Voice = Resources.Load("Voices/voice_toriel") as AudioClip;
		papyrus_Voice = Resources.Load("Voices/voice_papyrus") as AudioClip;
		sans_Voice = Resources.Load("Voices/voice_sans") as AudioClip;
	}

	// Use this for initialization
	void Start () {
		//changePortrait (toriel_face_Portrait, toriel_body_Portrait);
		changePortrait (papyrus_face_Portrait);
		changeVoice (papyrus_Voice);
	}

	// Update is called once per frame
	void Update () {
		current_face_Portrait.GetComponent<Animator> ().SetBool ("Speaking", GameObject.Find ("/Canvas/Dialogue_Text").GetComponent<textAutoType> ().getSpeaking ());
	}

	void changeVoice (AudioClip voice) {
		GameObject.Find ("/Canvas/Dialogue_Text").GetComponent<AudioSource>().clip = voice;
	}

	void changePortrait (GameObject face) {
		//Destroy existing portraits
		if (current_body_Portrait) {
			Destroy (current_body_Portrait);
		}
		if (current_face_Portrait) {
			Destroy (current_face_Portrait);
		}

		//Create chosen portrait
		current_face_Portrait = (GameObject) Instantiate (face);
		current_face_Portrait.transform.SetParent (transform.Find ("/Canvas"), false);
	}

	void changePortrait (GameObject face, GameObject body) {
		//Destroy existing portraits
		if (current_body_Portrait) {
			Destroy (current_body_Portrait);
		}
		if (current_face_Portrait) {
			Destroy (current_face_Portrait);
		}

		//Create chosen portraits
		current_face_Portrait = (GameObject) Instantiate (face);
		current_face_Portrait.transform.SetParent (transform.Find ("/Canvas"), false);
		current_body_Portrait = (GameObject) Instantiate (body);
		current_body_Portrait.transform.SetParent (transform.Find ("/Canvas"), false);
	}

	void speakLine (string name, string expression, string message) {

	}

}

using UnityEngine;
using System.Collections;

public class voiceScript : MonoBehaviour {
	private AudioSource source;
	private AudioClip clip;
	private float pitch = 1f;
	private int choice = 0;

	public AudioClip track1;
	public AudioClip track2;
	public AudioClip track3;
	public AudioClip track4;

	private bool play;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
		clip = source.clip;
		play = false;
	}
	
	// Update is called once per frame
	void Update () {
		//pitch = Random.Range (0, 3);
		//source.pitch = pitch;

	}

	AudioClip getTrack (int num){
		switch (num) {
		case 0:
			return track1;
			break;
		case 1:
			return track2;
			break;
		case 2:
			return track3;
			break;
		default:
			return track4;
		}
	}
}

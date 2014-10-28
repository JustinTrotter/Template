using UnityEngine;
using System.Collections;

public class gameManagerScript : MonoBehaviour {

	public GameObject musicManager;
	public musicManagerScript mMscript;

	// Use this for initialization
	void Start () {
		mMscript = musicManager.GetComponent<musicManagerScript> ();
		mMscript.loadSource (mMscript.source1, mMscript.track1);
		mMscript.playSource (mMscript.source1);
		mMscript.fadeSpeed = 1f;
		mMscript.source1.GetComponent<audioSourceScript> ().targetPitch = 2f;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class tempPlayerScript : MonoBehaviour {

	public bool inZone1 = false;
	public bool inZone2 = false;
	public bool inZone3 = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerStay(Collider col)
	{
		if (col.tag == "zone1") {
			inZone1 = true;
			inZone2 = false;
			inZone3 = false;
		}
		else if (col.tag == "zone2") {
			inZone2 = true;
			inZone1 = false;
			inZone3 = false;
		}
		else if (col.tag == "zone3") {
			inZone3 = true;
			inZone1 = false;
			inZone2 = false;
		}
	}
}

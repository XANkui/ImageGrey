using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour {

	public GameObject imageGo;
	public Material imageGrey;
	private bool isGrey = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.A)) {
			if (imageGo != null && imageGrey != null && isGrey == false) {

				imageGo.GetComponent <Image>().material = imageGrey;
				isGrey = true;
			}else if (imageGo != null && imageGrey != null && isGrey == true) {

				imageGo.GetComponent <Image>().material = null;
				isGrey = false;
			}
		}
	}
}

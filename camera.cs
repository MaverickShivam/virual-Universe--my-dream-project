using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {
    static WebCamTexture webCam;
    // Use this for initialization
    void Start() {
        if (webCam == null)
            webCam = new WebCamTexture();
        GetComponent<Renderer>().material.mainTexture = webCam;
        if (!webCam.isPlaying)
            webCam.Play(); 
	// Update is called once per frame
    }
	void Update () {
		
	}
}

using UnityEngine;
using System.Collections;

public class NextController : MonoBehaviour {

	void Start () {
		MediaPlayerCtrl srcMedia = GameObject.Find("sphere").GetComponent<MediaPlayerCtrl>();
		GameObject PlayerController = GameObject.Find("OVRPlayerController");
		GameObject Sphere =  GameObject.Find("sphere");
		GameObject VideoPlayerControls = GameObject.Find("Video Player Controls");

		//Video 1
		if (srcMedia.current_video == "video1.mp4")
			srcMedia.Load ("video2.mp4");
		//Video 2
		else if (srcMedia.current_video == "video2.mp4")
			srcMedia.Load ("video3.mp4");
		//Video 3
		else if (srcMedia.current_video == "video3.mp4")
			srcMedia.Load ("video4.mp4");
		//Video 4
		else if (srcMedia.current_video == "video4.mp4"){
			srcMedia.Load ("video1.mp4");

		}
		Destroy (gameObject);
	}
}

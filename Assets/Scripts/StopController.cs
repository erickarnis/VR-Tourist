using UnityEngine;
using System.Collections;

//Called by the stop message when it is instantiated. The videomessage should
//probably be done like this for performance reasons but it's not urgent
public class StopController : MonoBehaviour {

	void Start(){
		MediaPlayerCtrl srcMedia = GameObject.Find("sphere").GetComponent<MediaPlayerCtrl>();

		if (srcMedia.current_video == "video1.mp4")
			srcMedia.Load ("video1.mp4");
		else if (srcMedia.current_video == "video2.mp4")
			srcMedia.Load ("video2.mp4");
		else if (srcMedia.current_video == "video3.mp4")
			srcMedia.Load ("video3.mp4");
		else if (srcMedia.current_video == "video4.mp4")
			srcMedia.Load ("video4.mp4");

		srcMedia.Pause();
		Destroy (gameObject);
	}
}

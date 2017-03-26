using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//This file controls functions related to the main menu, including functions
//that load videos and control when buttons are enabled/disabled

//Use unload to reduce overhead
public class MenuScript : MonoBehaviour {
	//These are set in the inspector
	public MediaPlayerCtrl srcMedia;
	public int id;
	void Start(){
	}

	//This methods checks for the creation of signalling gameobjects and launches
	//the appropriate video.
	void Update(){
		id = PhotonNetwork.player.ID;
		//Launch video, destroy signalling gameobject
		if(GameObject.Find("VideoMessage(Clone)") != null){
			int message_id = (int) GameObject.Find("VideoMessage(Clone)").transform.position.x;
			int message_video = (int) GameObject.Find("VideoMessage(Clone)").transform.position.y;
			Debug.Log (message_id + " , " +  message_video);
			string video = "/storage/emulated/0/VRTourist/video" + message_video + ".mp4";
				Debug.Log(message_id + " vs " + id);
			if(message_id == 0 || message_id == id){
				srcMedia.Load (video);
			}
			Destroy(GameObject.Find("VideoMessage(Clone)"));
		}

	}

}

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
	public GameObject video_player_controls;
	public Text status_text;
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
			//For android
			string video = " file:///storage/emulated/0/VR-Tourism/video" + message_video + ".mp4";
			//For PC, with video located in streaming assets folder
			//string video = "video" + message_video + ".mp4";
			Debug.Log ("Launch " +  video);
		  Debug.Log(message_id + " vs " + id);
			if(message_id == 0 || message_id == id){
				video_player_controls.SetActive(false);
				try{
					srcMedia.Load(video);
				}
				catch(System.ApplicationException e){
					Debug.Log("Video couldn't be loaded, exception caught");
					video_player_controls.SetActive(true);
					status_text.text = " Can't find Video " + message_video;
				}
			}
			Destroy(GameObject.Find("VideoMessage(Clone)"));
		}

	}
	void OnApplicationPause(bool paused){
		if (paused == true){
			PhotonNetwork.Disconnect();
		}
		else{
			PhotonNetwork.ConnectUsingSettings("0.1");
		}
	}
	void OnApplicationFocus(bool focused){
		if (focused == true){
			PhotonNetwork.ConnectUsingSettings("0.1");
		}else{
			PhotonNetwork.Disconnect();
		}
	}

}

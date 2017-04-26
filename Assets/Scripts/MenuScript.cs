using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//This file contains functions that monitor the status of the player and check
//for messages
public class MenuScript : MonoBehaviour {
	//These are set in the inspector
	public MediaPlayerCtrl srcMedia;
	public GameObject video_player_controls;
	public Text status_text;
	public int id;
	//public bool load_error = false;

	//This method is run when the object the script is attached to is instantiated
	//In this case it is run when the game loads
	void Start(){

	}

//This method is called one every frame. Avoid putting too much stuff here
//because it's resource heavy
	void Update(){
		//This block checks for the creation of signalling gameobjects and launches
		//the appropriate video.
		id = PhotonNetwork.player.ID;
		if(GameObject.Find("VideoMessage(Clone)") != null){
			//This is the id of the player the message is intended for
			int message_id = (int) GameObject.Find("VideoMessage(Clone)").transform.position.x;
			//This is the video to launch
			int message_video = (int) GameObject.Find("VideoMessage(Clone)").transform.position.y;

			//For android, use this string and comment out the other string video line
			string video = " file:///storage/emulated/0/VR-Tourism/video" + message_video + ".mp4";
			//For PC, with video located in project's streaming assets folder
			//string video = "video" + message_video + ".mp4";

			Debug.Log ("Launch " +  video);
		  Debug.Log(message_id + " vs " + id);
			//If the message is intended for all players or this player specifically,
			//hide the white box and playe the specified video
			if(message_id == 0 || message_id == id){
				video_player_controls.transform.localScale = new Vector3(0,0,0);
				srcMedia.Load(video);
			}
			Destroy(GameObject.Find("VideoMessage(Clone)"));
		}
		/*
		if(load_error == true){
			Debug.Log ("found");
		}
		*/
	}
	/*
	void ChangeVPCActive(bool active){
		video_player_controls.SetActive(active);
	}
	*/
	//These two functions ensure that if the player takes off their headset the
	//game disconnects. This is useful because then the tour leader can monitor
	//that
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
	/*
	public void VideoLoadError(){
		load_error = true;
		Debug.Log("Video couldn't be loaded, exception caught");
		//for some reason, video_player_controls is null when accessed from this function
		//video_player_controls.transform.localScale = new Vector3(1,1,1);
		//status_text.text = " Can't find Video ";
	}
	*/
}

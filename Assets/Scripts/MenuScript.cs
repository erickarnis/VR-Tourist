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
	//public bool load_error = false;

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
			//For PC, with video located in project's streaming assets folder
			//string video = "video" + message_video + ".mp4";

			Debug.Log ("Launch " +  video);
		  Debug.Log(message_id + " vs " + id);

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
	//If the player takes off their headset the games disconnects
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

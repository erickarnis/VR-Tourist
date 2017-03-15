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
		//Launch video 1, destroy signalling gameobject
		if(GameObject.Find("video1(Clone)") != null){
			int signal = (int) GameObject.Find("video1(Clone)").transform.position.x;
			Debug.Log(signal + " vs " + id);
			if(signal == 0 || signal == id){
				srcMedia.Load ("video1.mp4");
			}
			Destroy(GameObject.Find("video1(Clone)"));
		}
		//Launch video 2, destroy signalling gameobject
		if(GameObject.Find("video2(Clone)") != null){
			int signal = (int) GameObject.Find("video2(Clone)").transform.position.x;
			if(signal == 0 || signal == id){
				srcMedia.Load ("video2.mp4");
			}
			Destroy(GameObject.Find("video2(Clone)"));
		}
		//Launch video 3, destroy signalling gameobject
		if(GameObject.Find("video3(Clone)") != null){
			int signal = (int) GameObject.Find("video3(Clone)").transform.position.x;
			if(signal == 0 || signal == id){
				srcMedia.Load ("video3.mp4");
			}
			Destroy(GameObject.Find("video3(Clone)"));
		}
		//Launch video 4, destroy signalling gameobject
		if(GameObject.Find("video4(Clone)") != null){
			int signal = (int) GameObject.Find("video4(Clone)").transform.position.x;
			if(signal == 0 || signal == id){
				srcMedia.Load ("video4.mp4");
			}
			Destroy(GameObject.Find("video4(Clone)"));
		}
	}

}

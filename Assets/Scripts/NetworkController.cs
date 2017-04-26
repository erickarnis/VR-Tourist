using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//This file contains functions that control the initial networking
public class NetworkController : MonoBehaviour{
	//Note that in order for a tourist and tour leader to communicate, they must
	//be in the same room.
	string _room = "VR Tourism";
	public Text status_text;

	//This method is run when the object the script is attached to is instantiated
	//In this case it is run when the game loads
	void Start(){
		PhotonNetwork.ConnectUsingSettings("0.1");
	}

	void OnJoinedLobby(){
		//This changes the text that floats in front of the user's eyes
		status_text.text = "Connected";
		Debug.Log("joined lobby");
		RoomOptions roomOptions = new RoomOptions() { };
		PhotonNetwork.JoinOrCreateRoom(_room, roomOptions, TypedLobby.Default);
	}

	void OnJoinedRoom(){

	}
	//Not working, even though the identical method in VR Tour Guide is working
	void OnConnectionFail(){
		Debug.Log("Connection lost");
		status_text.text = "Connection lost";
	}
}

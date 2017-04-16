using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NetworkController : MonoBehaviour
{
	string _room = "VR Tourism";
	public Text status_text;

	void Start(){
		PhotonNetwork.ConnectUsingSettings("0.1");
	}

	void OnJoinedLobby(){
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

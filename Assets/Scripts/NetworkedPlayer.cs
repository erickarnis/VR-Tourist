using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//This file contains functions that send and recieve streams of data to other
//players, including the tour leader. Start here if you want to implement
//video time monitoring
public class NetworkedPlayer : Photon.MonoBehaviour{

	public MediaPlayerCtrl srcMedia;

	void Start (){

	}
		void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info){
			//This sends your data to the other players in the same room
			if (stream.isWriting){
				stream.SendNext(PhotonNetwork.playerName.ToString());
				//Debug.Log(PhotonNetwork.playerName.ToString());
				stream.SendNext(srcMedia.GetSeekPosition());
				//Debug.Log(srcMedia.GetSeekPosition());
				stream.SendNext(srcMedia.GetDuration());
				//Debug.Log(srcMedia.GetDuration());
				stream.SendNext(srcMedia.current_video);
				//Debug.Log(srcMedia.current_video);
			}
			//This recieves information from other players in the same room
			else{
				int a = (int)stream.ReceiveNext();
				int b = (int)stream.ReceiveNext();
				string c = (string)stream.ReceiveNext();
			}
		}

}

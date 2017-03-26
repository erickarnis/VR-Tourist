using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NetworkedPlayer : Photon.MonoBehaviour{

	public MediaPlayerCtrl srcMedia;

	void Start (){

	}
		void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info){
			//This sends your data to the other players in the same room
			if (stream.isWriting){
				stream.SendNext(PhotonNetwork.playerName.ToString());
				Debug.Log(PhotonNetwork.playerName.ToString());
				stream.SendNext(srcMedia.GetSeekPosition());
				Debug.Log(srcMedia.GetSeekPosition());
				stream.SendNext(srcMedia.GetDuration());
				Debug.Log(srcMedia.GetDuration());
				stream.SendNext(srcMedia.current_video);
				Debug.Log(srcMedia.current_video);
			}
			//This recieves information from other players in the same room
			else{
				int a = (int)stream.ReceiveNext();
				int b = (int)stream.ReceiveNext();
				string c = (string)stream.ReceiveNext();
			}
		}
/*
	void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info){
		//This sends your data to the other players in the same room
		if (stream.isWriting){
			stream.SendNext(playerGlobal.position);
			stream.SendNext(playerGlobal.rotation);
			stream.SendNext(playerLocal.localPosition);
			stream.SendNext(playerLocal.localRotation);
		}
		//This recieves information from other players in the same room
		else{
			this.transform.position = (Vector3)stream.ReceiveNext();
			this.transform.rotation = (Quaternion)stream.ReceiveNext();
			avatar.transform.localPosition = (Vector3)stream.ReceiveNext();
			avatar.transform.localRotation = (Quaternion)stream.ReceiveNext();

			//This makes the other player's arrows point forward
			avatar.transform.Rotate (0, 180, 0);
		}
	}*/
}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NetworkedPlayer : Photon.MonoBehaviour{
	public GameObject avatar;

	//Responsible for avatar movements on the plane
	public Transform playerGlobal;
	//Responsible for headmovements
	public Transform playerLocal;
	public Transform playerRotation;

	public MediaPlayerCtrl srcMedia;

	void Start (){

		//this ensures that only you can control your player
		if (photonView.isMine){
			playerGlobal = GameObject.Find("OVRPlayerController").transform;
			playerLocal = playerGlobal.Find("OVRCameraRig/TrackingSpace/CenterEyeAnchor/Pivot");
			playerRotation = playerGlobal.Find("OVRCameraRig/TrackingSpace/CenterEyeAnchor");

			this.transform.SetParent(playerLocal);
			this.transform.localPosition = Vector3.zero;
			this.transform.rotation = playerRotation.transform.rotation;

			//Throws null
			//GetComponent<PhotonVoiceRecorder> ().enabled = true;
		}
	}
		void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info){
			//This sends your data to the other players in the same room
			if (stream.isWriting){
				stream.SendNext(srcMedia.GetSeekPosition());
				stream.SendNext(srcMedia.GetDuration());

			}
			//This recieves information from other players in the same room
			else{

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

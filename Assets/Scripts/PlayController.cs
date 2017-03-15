using UnityEngine;
using System.Collections;

public class PlayController : MonoBehaviour {

	void Start(){
		GameObject.Find("sphere").GetComponent<MediaPlayerCtrl>().Play();
		Destroy (gameObject);
	}
}

using UnityEngine;
using System.Collections;

public class PauseController : MonoBehaviour {

	void Start(){
		GameObject.Find("sphere").GetComponent<MediaPlayerCtrl>().Pause();
		Destroy (gameObject);
	}
}

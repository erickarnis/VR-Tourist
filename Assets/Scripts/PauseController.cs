using UnityEngine;
using System.Collections;

//Called by the pause message when it is instantiated. The videomessage should
//probably be done like this for performance reasons but it's not urgent
public class PauseController : MonoBehaviour {

	void Start(){
		GameObject.Find("sphere").GetComponent<MediaPlayerCtrl>().Pause();
		Destroy (gameObject);
	}
}

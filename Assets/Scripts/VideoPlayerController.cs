using UnityEngine;
using System.Collections;

public class VideoPlayerController : MonoBehaviour {
	public GameObject sphere, next, previous;

	public void Play (){
		sphere.GetComponent<MediaPlayerCtrl>().Play();
	}

	public void Stop (){
		sphere.GetComponent<MediaPlayerCtrl>().Stop();
	}

	public void Pause (){
		sphere.GetComponent<MediaPlayerCtrl>().Pause();
	}

	public void Next (){
		Instantiate(next, Vector3.zero, Quaternion.identity);
	}

	public void Previous (){
		Instantiate(previous, Vector3.zero, Quaternion.identity);
	}
}

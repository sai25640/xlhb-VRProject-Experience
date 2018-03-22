using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RenderHeads.Media.AVProVideo;

public class MediaPlayerController : MonoBehaviour {

    public MediaPlayer mediaPlayer;
    
    public void OnPlayButtonClick()
    {
        mediaPlayer.Control.Play();
    }

    public void OnStopButtonClick()
    {
        mediaPlayer.Control.Stop();
    }
}

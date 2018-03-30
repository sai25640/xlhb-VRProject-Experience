using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManager : TestManager {

    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvas3;
    public GameObject canvas4;
    public GameObject canvas5;
    public Angel angel;
    public GameObject clip0;
    public GameObject clip1;
    public GameObject clip2;
    public GameObject clip3;
    public GameObject clip4;
    public GameObject clip5;
    public GameObject clip6;
    public override void OnWallButtonClick()
    {
        base.OnWallButtonClick();
        clip0.SetActive(false);
        clip1.SetActive(true);
        //AudioClip clip = clip6.GetComponent<AudioSource>().clip;
        //clip0.GetComponent<AudioSource>().PlayOneShot(clip);
    }

    public override void OnWall1ButtonClick()
    {
        base.OnWall1ButtonClick();
        canvas1.SetActive(true);
        clip1.SetActive(false);
        clip2.SetActive(true);
    }

    public override void OnWall2ButtonClick()
    {
        base.OnWall2ButtonClick();
        canvas2.SetActive(true);
        clip2.SetActive(false);
        clip3.SetActive(true);
    }

    public override void OnWall3ButtonClick()
    {
        base.OnWall3ButtonClick();
        canvas3.SetActive(true);
        clip3.SetActive(false);
        clip4.SetActive(true);
    }

    public override void OnWall4ButtonClick()
    {
        base.OnWall4ButtonClick();
        canvas4.SetActive(true);
        clip4.SetActive(false);
        clip5.SetActive(true);
    }

    public override void OnWall5ButtonClick()
    {
        base.OnWall5ButtonClick();
        canvas5.SetActive(true);
        angel.enabled = true;
        clip5.SetActive(false);
        clip6.SetActive(true);
    }
}

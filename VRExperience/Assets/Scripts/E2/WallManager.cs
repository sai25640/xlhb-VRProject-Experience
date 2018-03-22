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
    public override void OnWallButtonClick()
    {
        base.OnWallButtonClick();
       
    }

    public override void OnWall1ButtonClick()
    {
        base.OnWall1ButtonClick();
        canvas1.SetActive(true);

    }

    public override void OnWall2ButtonClick()
    {
        base.OnWall2ButtonClick();
        canvas2.SetActive(true);

    }

    public override void OnWall3ButtonClick()
    {
        base.OnWall3ButtonClick();
        canvas3.SetActive(true);

    }

    public override void OnWall4ButtonClick()
    {
        base.OnWall4ButtonClick();
        canvas4.SetActive(true);

    }

    public override void OnWall5ButtonClick()
    {
        base.OnWall5ButtonClick();
        canvas5.SetActive(true);
        angel.enabled = true;

    }
}

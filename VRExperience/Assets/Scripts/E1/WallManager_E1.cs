using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManager_E1 : MonoBehaviour {

    public GameObject wall;
    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject wall4;
    public GameObject wall5;
    public GameObject guide;
    public GameObject guide1;
    public GameObject guide2;
    public GameObject guide3;
    public GameObject guide4;
    public GameObject guide5;
    public GameObject voice0;
    public GameObject voice1;
    public GameObject voice2;
    public GameObject voice3;
    public GameObject voice4;
    public GameObject voice5;
    public GameObject voice6;

    public virtual void OnWallButtonClick()
    {
        wall.SetActive(false);
        wall1.SetActive(true);
        guide.SetActive(true);
        voice0.SetActive(false);
        voice1.SetActive(true);
    }

    public virtual void OnWall1ButtonClick()
    {
        wall1.SetActive(false);
        wall2.SetActive(true);
        guide1.SetActive(true);
        voice1.SetActive(false);
        voice2.SetActive(true);
    }

    public virtual void OnWall2ButtonClick()
    {
        wall2.SetActive(false);
        wall3.SetActive(true);
        guide2.SetActive(true);
        voice2.SetActive(false);
        voice3.SetActive(true);
    }

    public virtual void OnWall3ButtonClick()
    {
        wall3.SetActive(false);
        wall4.SetActive(true);
        guide3.SetActive(true);
        voice3.SetActive(false);
        voice4.SetActive(true);
    }

    public virtual void OnWall4ButtonClick()
    {
        wall4.SetActive(false);
        wall5.SetActive(true);
        guide4.SetActive(true);
        voice4.SetActive(false);
        voice5.SetActive(true);
    }

    public virtual void OnWall5ButtonClick()
    {
        wall5.SetActive(false);
        guide5.SetActive(true);
        voice5.SetActive(false);
        voice6.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour {

    public GameObject wall;
    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject wall4;
    public GameObject wall5;

    public virtual void OnWallButtonClick()
    {
        wall.SetActive(false);
        wall1.SetActive(true);
    }

    public virtual void OnWall1ButtonClick()
    {
        wall1.SetActive(false);
        wall2.SetActive(true);
    }

    public virtual void OnWall2ButtonClick()
    {
        wall2.SetActive(false);
        wall3.SetActive(true);
    }

    public virtual void OnWall3ButtonClick()
    {
        wall3.SetActive(false);
        wall4.SetActive(true);
    }

    public virtual void OnWall4ButtonClick()
    {
        wall4.SetActive(false);
        wall5.SetActive(true);
    }

    public virtual void OnWall5ButtonClick()
    {
        wall5.SetActive(false);
    }
}

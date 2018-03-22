using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 用于两个题目两个选项的墙面
/// </summary>
public class WallTest : MonoBehaviour {

    public Text w1t1ButtonA;
    public Text w1t1ButtonB;
    public Image w1t1Mask;
    public GameObject w1t1Panel;
    public GameObject w1t2Panel;
    public Text w1t2ButtonA;
    public Text w1t2ButtonB;
    public Image w1t2Mask;

    public void OnW1T1ButtonAClick()
    {
        w1t1ButtonA.color = new Color(255f, 0, 0);
        w1t1ButtonB.color = new Color(255f, 255f, 255f);
        w1t1Mask.enabled = false;
        w1t1ButtonA.transform.parent.GetComponent<Button>().enabled = false;
        w1t1ButtonB.transform.parent.GetComponent<Button>().enabled = false;
    }

    public void OnW1T1ButtonBClick()
    {
        w1t1ButtonA.color = new Color(255f, 255f, 255f);
        w1t1ButtonB.color = new Color(0, 255f, 0);
        w1t1Mask.enabled = false;
        w1t1ButtonA.transform.parent.GetComponent<Button>().enabled = false;
        w1t1ButtonB.transform.parent.GetComponent<Button>().enabled = false;
    }

    public void OnW1T1NextButtonClick()
    {
        w1t1Panel.SetActive(false);
        w1t2Panel.SetActive(true);
    }

    public void OnW1T2ButtonAClick()
    {
        w1t2ButtonA.color = new Color(0, 255f, 0);
        w1t2ButtonB.color = new Color(255f, 255f, 255f);
        w1t2Mask.enabled = false;
        w1t2ButtonA.transform.parent.GetComponent<Button>().enabled = false;
        w1t2ButtonB.transform.parent.GetComponent<Button>().enabled = false;
    }

    public void OnW1T2ButtonBClick()
    {
        w1t2ButtonA.color = new Color(255f, 255f, 255f);
        w1t2ButtonB.color = new Color(255f, 0, 0);
        w1t2Mask.enabled = false;
        w1t2ButtonA.transform.parent.GetComponent<Button>().enabled = false;
        w1t2ButtonB.transform.parent.GetComponent<Button>().enabled = false;
    }

    public void OnW1T2AgainButtonClick()
    {
        w1t1ButtonA.color = new Color(255f, 255f, 255f);
        w1t1ButtonB.color = new Color(255f, 255f, 255f);
        w1t1Mask.enabled = true;
        w1t2ButtonA.color = new Color(255f, 255f, 255f);
        w1t2ButtonB.color = new Color(255f, 255f, 255f);
        w1t2Mask.enabled = true;
        w1t1Panel.SetActive(true);
        w1t2Panel.SetActive(false);
        w1t1ButtonA.transform.parent.GetComponent<Button>().enabled = true;
        w1t1ButtonB.transform.parent.GetComponent<Button>().enabled = true;
        w1t2ButtonA.transform.parent.GetComponent<Button>().enabled = true;
        w1t2ButtonB.transform.parent.GetComponent<Button>().enabled = true;

    }
}

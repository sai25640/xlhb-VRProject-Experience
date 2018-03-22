using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManagerForLogin: MonoBehaviour
{
    public void OnE1Click()
    {
        SceneManager.LoadScene("E1_Judicature");
    }

    public void OnE2Click()
    {
        SceneManager.LoadScene("E2_MindCare");
    }

    public void OnQuitButtonClick()
    {
        SceneManager.LoadScene("LoginScene");
    }
}

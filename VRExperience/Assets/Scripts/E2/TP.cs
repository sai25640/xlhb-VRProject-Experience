using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TP : MonoBehaviour {

    void OnTriggerStay(Collider other)
    {
        Debug.Log("other ：" + other.name);
        //if (other.name == "[VRTK][AUTOGEN][BodyColliderContainer]")
        //{
        //    SceneManager.LoadScene("LoginScene");
        //}
        if (other.name == "Player")
        {
            SceneManager.LoadScene("LoginScene");
        }
    }
    //void OnCollisionStay(Collision collision)
    //{
    //    Debug.Log("collision ：" + collision.gameObject.name);
    //    if (collision.gameObject.name == "[VRTK][AUTOGEN][BodyColliderContainer]")
    //    {
    //        SceneManager.LoadScene("LoginScene");
    //    }
    //}
}

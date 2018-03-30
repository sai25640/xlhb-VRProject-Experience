using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using UnityEngine.UI;
public class Egg : MonoBehaviour
{
    public VRTK_InteractTouch interactTouch;
    public VRTK_ControllerEvents controllerEvents;
    private bool isTouch = false;
    public Light light;
    private float curAxisX = -90;
    private float maxAxisX = 30f;
    //public Text eggText;
    public GameObject room;
    public Light light2;
    public Light light3;
    public Material skybox;
    public GameObject plane;
    public GameObject particle;
    private void Start()
    {
        //curAxisX = light.transform.eulerAngles.x;
        Debug.Log("curAxisX =" + curAxisX);
    }
    private void OnEnable()
    {
        if (controllerEvents)
        {
            controllerEvents.TriggerPressed += this.DoTriggerPressed;
        }
        if (interactTouch)
        {
            interactTouch.ControllerTouchInteractableObject += this.OnTouched;
        }
    }

    private void OnDisable()
    {
        if (controllerEvents)
        {
            controllerEvents.TriggerPressed -= this.DoTriggerPressed;
        }
        if (interactTouch)
        {
            interactTouch.ControllerTouchInteractableObject -= this.OnTouched;
        }
    }
  
    public void DoTriggerPressed(object sender, ControllerInteractionEventArgs e)
    {
     
 
    }

    public void OnTouched(object sender,ObjectInteractEventArgs e)
    {

        if (isTouch == true) return;
        //Debug.Log("OnTouched");
        isTouch = true;
        Invoke("TouchChanged", 1f);

        curAxisX += 30f;
        Debug.Log("curAxisX =" + curAxisX);
        if (curAxisX >= maxAxisX)
        {
            curAxisX = maxAxisX;
            this.gameObject.SetActive(false);
            room.SetActive(true);
            light2.gameObject.SetActive(true);
            light3.gameObject.SetActive(true);
            RenderSettings.skybox = skybox;
            plane.SetActive(false);
            particle.SetActive(false);

        }
        light.transform.eulerAngles =  new Vector3(curAxisX , 0,0); 

        //添加手柄震动效果
        VRTK_ControllerReference controllerReference = new VRTK_ControllerReference(SDK_BaseController.ControllerHand.Right);
        VRTK_ControllerHaptics.TriggerHapticPulse(controllerReference, 1f, 0.3f, 0.01f);

       
    }

    public void OnUnTouched(object sender, ObjectInteractEventArgs e)
    {
        isTouch = false;
        Debug.Log("OnUnTouched");
    }

    private void TouchChanged()
    {
        isTouch = false;
        Debug.Log("OnUnTouched");
    }


    }

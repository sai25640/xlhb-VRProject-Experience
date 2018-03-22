using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using DG.Tweening;

public class OffenderTouchEvent : MonoBehaviour
{
    public VRTK_InteractTouch interactTouch;
    public VRTK_ControllerEvents controllerEvents;
    private bool isTouch = false;
    public GameObject banButtonCanvas;
    public Animation girlAnimation;
    public Animation boyAnimation;
    public GameObject police;
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
        //banButtonCanvas.transform.DOScale(0.003f, 1f);
        banButtonCanvas.SetActive(true);
        Invoke("HideBanButtonCanvas", 10f);
    }

    private void HideBanButtonCanvas()
    {
        banButtonCanvas.SetActive(false);
        isTouch = false;
    }

    public void OnBanButtonClick()
    {
        //Debug.Log("出现警察的动画");
        police.SetActive(true);
        this.transform.GetComponent<Animation>().enabled = false;
        if(girlAnimation)
            girlAnimation.enabled = false;
        if (boyAnimation)
        {
            boyAnimation.enabled = false;
        }
    }
}

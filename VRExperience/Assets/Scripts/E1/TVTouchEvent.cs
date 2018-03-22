using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class TVTouchEvent : MonoBehaviour
{
    public VRTK_InteractTouch interactTouch;
    public VRTK_ControllerEvents controllerEvents;
    public VRTK_UIPointer uiPointer;
    private bool isTouch = false;

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
        if (uiPointer)
        {
            uiPointer.UIPointerElementClick += this.OnUIPointerElementClick;
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
    }

    public void OnUIPointerElementClick(object sender, UIPointerEventArgs e)
    {
        //添加手柄震动效果
        VRTK_ControllerReference controllerReference = new VRTK_ControllerReference(SDK_BaseController.ControllerHand.Right);
        VRTK_ControllerHaptics.TriggerHapticPulse(controllerReference, 0.1f, 0.1f, 0.01f);
    }

 
}

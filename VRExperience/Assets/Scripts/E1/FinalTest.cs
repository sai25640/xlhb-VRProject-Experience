using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FinalTest : MonoBehaviour {

    public GameObject BeginPanel;
    public Text BeginText;
    public GameObject T1Panel;
    public GameObject T2Panel;
    public GameObject T3Panel;
    public GameObject T4Panel;
    public GameObject T5Panel;
    public GameObject T6Panel;
    public GameObject T7Panel;
    public GameObject T8Panel;
    public GameObject T9Panel;
    public GameObject T10Panel;
    public GameObject T11Panel;
    public GameObject T12Panel;
    public GameObject T13Panel;
    public GameObject T14Panel;
    public GameObject T15Panel;
    public GameObject T16Panel;
    public GameObject T17Panel;
    public GameObject T18Panel;
    public GameObject T19Panel;
    public GameObject T20Panel;
    public GameObject FinalPanel1;
    public GameObject FinalPanel2;
    public GameObject FinalPanel3;
    public GameObject FinalPanel4;
    public GameObject FinalPanel5;

    public void OnBeginButtonClick()
    {
        BeginPanel.SetActive(false);
        T1Panel.SetActive(true);
    }

    public void OnT1NextButtonClick()
    {
        if (FinalTestCount.isT1Finished == false) return;
       
        T1Panel.SetActive(false);
        T2Panel.SetActive(true);
    }

    public void OnT2LastButtonClick()
    {
        T1Panel.SetActive(true);
        T2Panel.SetActive(false);
    }
    public void OnT2NextButtonClick()
    {
        if (FinalTestCount.isT2Finished == false) return;

        T2Panel.SetActive(false);
        T3Panel.SetActive(true);
    }

    public void OnT3LastButtonClick()
    {
        T2Panel.SetActive(true);
        T3Panel.SetActive(false);
    }
    public void OnT3NextButtonClick()
    {
        if (FinalTestCount.isT3Finished == false) return;
        T3Panel.SetActive(false);
        T4Panel.SetActive(true);
    }

    public void OnT4LastButtonClick()
    {
        T3Panel.SetActive(true);
        T4Panel.SetActive(false);
    }
    public void OnT4NextButtonClick()
    {
        if (FinalTestCount.isT4Finished == false) return;
        T4Panel.SetActive(false);
        T5Panel.SetActive(true);
    }

    public void OnT5LastButtonClick()
    {
        T4Panel.SetActive(true);
        T5Panel.SetActive(false);
    }
    public void OnT5NextButtonClick()
    {
        if (FinalTestCount.isT5Finished == false) return;
        T5Panel.SetActive(false);
        T6Panel.SetActive(true);
    }

    public void OnT6LastButtonClick()
    {
        T5Panel.SetActive(true);
        T6Panel.SetActive(false);
    }
    public void OnT6NextButtonClick()
    {
        if (FinalTestCount.isT6Finished == false) return;
        T6Panel.SetActive(false);
        T7Panel.SetActive(true);
    }

    public void OnT7LastButtonClick()
    {
        T6Panel.SetActive(true);
        T7Panel.SetActive(false);
    }
    public void OnT7NextButtonClick()
    {
        if (FinalTestCount.isT7Finished == false) return;
        T7Panel.SetActive(false);
        T8Panel.SetActive(true);
    }

    public void OnT8LastButtonClick()
    {

        T7Panel.SetActive(true);
        T8Panel.SetActive(false);
    }
    public void OnT8NextButtonClick()
    {
        if (FinalTestCount.isT8Finished == false) return;
        T8Panel.SetActive(false);
        T9Panel.SetActive(true);
    }

    public void OnT9LastButtonClick()
    {
        T8Panel.SetActive(true);
        T9Panel.SetActive(false);
    }
    public void OnT9NextButtonClick()
    {
        if (FinalTestCount.isT9Finished == false) return;
        T9Panel.SetActive(false);
        T10Panel.SetActive(true);
    }

    public void OnT10LastButtonClick()
    {
        T9Panel.SetActive(true);
        T10Panel.SetActive(false);
    }
    public void OnT10NextButtonClick()
    {
        if (FinalTestCount.isT10Finished == false) return;
        T10Panel.SetActive(false);
        T11Panel.SetActive(true);
    }

    public void OnT11LastButtonClick()
    {
        T10Panel.SetActive(true);
        T11Panel.SetActive(false);
    }
    public void OnT11NextButtonClick()
    {
        if (FinalTestCount.isT11Finished == false) return;
        T11Panel.SetActive(false);
        T12Panel.SetActive(true);
    }

    public void OnT12LastButtonClick()
    {
        T11Panel.SetActive(true);
        T12Panel.SetActive(false);
    }
    public void OnT12NextButtonClick()
    {
        if (FinalTestCount.isT12Finished == false) return;
        T12Panel.SetActive(false);
        T13Panel.SetActive(true);
    }

    public void OnT13LastButtonClick()
    {
        T12Panel.SetActive(true);
        T13Panel.SetActive(false);
    }
    public void OnT13NextButtonClick()
    {
        if (FinalTestCount.isT13Finished == false) return;
        T13Panel.SetActive(false);
        T14Panel.SetActive(true);
    }

    public void OnT14LastButtonClick()
    {
        T13Panel.SetActive(true);
        T14Panel.SetActive(false);
    }
    public void OnT14NextButtonClick()
    {
        if (FinalTestCount.isT14Finished == false) return;
        T14Panel.SetActive(false);
        T15Panel.SetActive(true);
    }

    public void OnT15LastButtonClick()
    {
        T14Panel.SetActive(true);
        T15Panel.SetActive(false);
    }
    public void OnT15NextButtonClick()
    {
        if (FinalTestCount.isT15Finished == false) return;
        T15Panel.SetActive(false);
        T16Panel.SetActive(true);
    }

    public void OnT16LastButtonClick()
    {
        T15Panel.SetActive(true);
        T16Panel.SetActive(false);
    }
    public void OnT16NextButtonClick()
    {
        if (FinalTestCount.isT16Finished == false) return;
        T16Panel.SetActive(false);
        T17Panel.SetActive(true);
    }

    public void OnT17LastButtonClick()
    {
        T16Panel.SetActive(true);
        T17Panel.SetActive(false);
    }
    public void OnT17NextButtonClick()
    {
        if (FinalTestCount.isT17Finished == false) return;
        T17Panel.SetActive(false);
        T18Panel.SetActive(true);
    }

    public void OnT18LastButtonClick()
    {
        T17Panel.SetActive(true);
        T18Panel.SetActive(false);
    }
    public void OnT18NextButtonClick()
    {
        if (FinalTestCount.isT18Finished == false) return;
        T18Panel.SetActive(false);
        T19Panel.SetActive(true);
    }

    public void OnT19LastButtonClick()
    {
        T18Panel.SetActive(true);
        T19Panel.SetActive(false);
    }
    public void OnT19NextButtonClick()
    {
        if (FinalTestCount.isT19Finished == false) return;
        T19Panel.SetActive(false);
        T20Panel.SetActive(true);
    }

    public void OnT20LastButtonClick()
    {
        T19Panel.SetActive(true);
        T20Panel.SetActive(false);
    }
    public void OnT20NextButtonClick()
    {
        if (FinalTestCount.isT20Finished == false) return;

        //统计分数然后根据分数出不同的分析报告
        FinalTestCount.FinalCount();
        Debug.Log("finalCount =" + FinalTestCount.finalCount);
        BeginText.enabled = false;
        T20Panel.SetActive(false);
        if (FinalTestCount.finalCount>=-40 && FinalTestCount.finalCount<=5)
        {
            FinalPanel1.SetActive(true);
        }
        else if(FinalTestCount.finalCount > 5 && FinalTestCount.finalCount <= 16)
        {
            FinalPanel2.SetActive(true);
        }
        else if (FinalTestCount.finalCount > 16 && FinalTestCount.finalCount <= 28)
        {
            FinalPanel3.SetActive(true);
        }
        else if (FinalTestCount.finalCount > 28 && FinalTestCount.finalCount <= 34)
        {
            FinalPanel4.SetActive(true);
        }
        else if (FinalTestCount.finalCount > 34 && FinalTestCount.finalCount <= 40)
        {
            FinalPanel5.SetActive(true);
        }
        
      
    }

   public void OnAgainButtonClick()
    {
        FinalPanel1.SetActive(false);
        FinalPanel2.SetActive(false);
        FinalPanel3.SetActive(false);
        FinalPanel4.SetActive(false);
        FinalPanel5.SetActive(false);
        BeginText.enabled = true;
        T1Panel.SetActive(true);
    }
}

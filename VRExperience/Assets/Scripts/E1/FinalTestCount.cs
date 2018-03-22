using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FinalTestCount : MonoBehaviour {

    enum SELECTION
    {
        YES,
        UNIDENTIFIED,
        NO,
    }

    private static SELECTION t1Selection;
    private static SELECTION t2Selection;
    private static SELECTION t3Selection;
    private static SELECTION t4Selection;
    private static SELECTION t5Selection;
    private static SELECTION t6Selection;
    private static SELECTION t7Selection;
    private static SELECTION t8Selection;
    private static SELECTION t9Selection;
    private static SELECTION t10Selection;
    private static SELECTION t11Selection;
    private static SELECTION t12Selection;
    private static SELECTION t13Selection;
    private static SELECTION t14Selection;
    private static SELECTION t15Selection;
    private static SELECTION t16Selection;
    private static SELECTION t17Selection;
    private static SELECTION t18Selection;
    private static SELECTION t19Selection;
    private static SELECTION t20Selection;
    public static int finalCount = 0;

    public Text T1ButtonA;
    public Text T1ButtonB;
    public Text T1ButtonC;
    public Text T2ButtonA;
    public Text T2ButtonB;
    public Text T2ButtonC;
    public Text T3ButtonA;
    public Text T3ButtonB;
    public Text T3ButtonC;
    public Text T4ButtonA;
    public Text T4ButtonB;
    public Text T4ButtonC;
    public Text T5ButtonA;
    public Text T5ButtonB;
    public Text T5ButtonC;
    public Text T6ButtonA;
    public Text T6ButtonB;
    public Text T6ButtonC;
    public Text T7ButtonA;
    public Text T7ButtonB;
    public Text T7ButtonC;
    public Text T8ButtonA;
    public Text T8ButtonB;
    public Text T8ButtonC;
    public Text T9ButtonA;
    public Text T9ButtonB;
    public Text T9ButtonC;
    public Text T10ButtonA;
    public Text T10ButtonB;
    public Text T10ButtonC;
    public Text T11ButtonA;
    public Text T11ButtonB;
    public Text T11ButtonC;
    public Text T12ButtonA;
    public Text T12ButtonB;
    public Text T12ButtonC;
    public Text T13ButtonA;
    public Text T13ButtonB;
    public Text T13ButtonC;
    public Text T14ButtonA;
    public Text T14ButtonB;
    public Text T14ButtonC;
    public Text T15ButtonA;
    public Text T15ButtonB;
    public Text T15ButtonC;
    public Text T16ButtonA;
    public Text T16ButtonB;
    public Text T16ButtonC;
    public Text T17ButtonA;
    public Text T17ButtonB;
    public Text T17ButtonC;
    public Text T18ButtonA;
    public Text T18ButtonB;
    public Text T18ButtonC;
    public Text T19ButtonA;
    public Text T19ButtonB;
    public Text T19ButtonC;
    public Text T20ButtonA;
    public Text T20ButtonB;
    public Text T20ButtonC;

    public static bool isT1Finished = false;
    public static bool isT2Finished = false;
    public static bool isT3Finished = false;
    public static bool isT4Finished = false;
    public static bool isT5Finished = false;
    public static bool isT6Finished = false;
    public static bool isT7Finished = false;
    public static bool isT8Finished = false;
    public static bool isT9Finished = false;
    public static bool isT10Finished = false;
    public static bool isT11Finished = false;
    public static bool isT12Finished = false;
    public static bool isT13Finished = false;
    public static bool isT14Finished = false;
    public static bool isT15Finished = false;
    public static bool isT16Finished = false;
    public static bool isT17Finished = false;
    public static bool isT18Finished = false;
    public static bool isT19Finished = false;
    public static bool isT20Finished = false;

    public static void FinalCount()
    {
        switch (t1Selection)
        {
            case SELECTION.YES:
                finalCount -= 2;
                break;
            case SELECTION.UNIDENTIFIED:
                break;
            case SELECTION.NO:
                finalCount += 2;
                break;
            default:
                break;
        }

        switch (t2Selection)
        {
            case SELECTION.YES:
                finalCount += 2; 
                break;
            case SELECTION.UNIDENTIFIED:
                break;
            case SELECTION.NO:
                finalCount -= 2;
                break;
            default:
                break;
        }

        switch (t3Selection)
        {
            case SELECTION.YES:
                finalCount -= 2;
                break;
            case SELECTION.UNIDENTIFIED:
                break;
            case SELECTION.NO:
                finalCount += 2; 
                break;
            default:
                break;
        }

        switch (t4Selection)
        {
            case SELECTION.YES:
                finalCount += 2; 
                break;
            case SELECTION.UNIDENTIFIED:
                break;
            case SELECTION.NO:
                finalCount -= 2;
                break;
            default:
                break;
        }

        switch (t5Selection)
        {
            case SELECTION.YES:
                finalCount -= 2;
                break;
            case SELECTION.UNIDENTIFIED:
                break;
            case SELECTION.NO:
                finalCount += 2; 
                break;
            default:
                break;
        }

        switch (t6Selection)
        {
            case SELECTION.YES:
                finalCount += 2; 
                break;
            case SELECTION.UNIDENTIFIED:
                break;
            case SELECTION.NO:
                finalCount -= 2;
                break;
            default:
                break;
        }

        switch (t7Selection)
        {
            case SELECTION.YES:
                finalCount -= 2;
                break;
            case SELECTION.UNIDENTIFIED:
                break;
            case SELECTION.NO:
                finalCount += 2; 
                break;
            default:
                break;
        }

        switch (t8Selection)
        {
            case SELECTION.YES:
                finalCount += 2; 
                break;
            case SELECTION.UNIDENTIFIED:
                break;
            case SELECTION.NO:
                finalCount -= 2;
                break;
            default:
                break;
        }

        switch (t9Selection)
        {
            case SELECTION.YES:
                finalCount -= 2;
                break;
            case SELECTION.UNIDENTIFIED:
                break;
            case SELECTION.NO:
                finalCount += 2; 
                break;
            default:
                break;
        }

        switch (t10Selection)
        {
            case SELECTION.YES:
                finalCount += 2; 
                break;
            case SELECTION.UNIDENTIFIED:
                break;
            case SELECTION.NO:
                finalCount -= 2;
                break;
            default:
                break;
        }

        switch (t11Selection)
        {
            case SELECTION.YES:
                finalCount -= 2;
                break;
            case SELECTION.UNIDENTIFIED:
                break;
            case SELECTION.NO:
                finalCount += 2;
                break;
            default:
                break;
        }

        switch (t12Selection)
        {
            case SELECTION.YES:
                finalCount += 2;
                break;
            case SELECTION.UNIDENTIFIED:
                break;
            case SELECTION.NO:
                finalCount -= 2;
                break;
            default:
                break;
        }

        switch (t13Selection)
        {
            case SELECTION.YES:
                finalCount -= 2;
                break;
            case SELECTION.UNIDENTIFIED:
                break;
            case SELECTION.NO:
                finalCount += 2;
                break;
            default:
                break;
        }

        switch (t14Selection)
        {
            case SELECTION.YES:
                finalCount += 2;
                break;
            case SELECTION.UNIDENTIFIED:
                break;
            case SELECTION.NO:
                finalCount -= 2;
                break;
            default:
                break;
        }

        switch (t15Selection)
        {
            case SELECTION.YES:
                finalCount -= 2;
                break;
            case SELECTION.UNIDENTIFIED:
                break;
            case SELECTION.NO:
                finalCount += 2;
                break;
            default:
                break;
        }

        switch (t16Selection)
        {
            case SELECTION.YES:
                finalCount += 2;
                break;
            case SELECTION.UNIDENTIFIED:
                break;
            case SELECTION.NO:
                finalCount -= 2;
                break;
            default:
                break;
        }

        switch (t17Selection)
        {
            case SELECTION.YES:
                finalCount -= 2;
                break;
            case SELECTION.UNIDENTIFIED:
                break;
            case SELECTION.NO:
                finalCount += 2;
                break;
            default:
                break;
        }

        switch (t18Selection)
        {
            case SELECTION.YES:
                finalCount += 2;
                break;
            case SELECTION.UNIDENTIFIED:
                break;
            case SELECTION.NO:
                finalCount -= 2;
                break;
            default:
                break;
        }

        switch (t19Selection)
        {
            case SELECTION.YES:
                finalCount -= 2;
                break;
            case SELECTION.UNIDENTIFIED:
                break;
            case SELECTION.NO:
                finalCount += 2;
                break;
            default:
                break;
        }

        switch (t20Selection)
        {
            case SELECTION.YES:
                finalCount += 2;
                break;
            case SELECTION.UNIDENTIFIED:
                break;
            case SELECTION.NO:
                finalCount -= 2;
                break;
            default:
                break;
        }

        Debug.Log("finalCount =" + finalCount);
    }
    public void OnT1ButtonA()
    {
        t1Selection = SELECTION.YES;
        T1ButtonA.color = new Color(0, 255f, 0);
        T1ButtonB.color = new Color(255f, 255f, 255f);
        T1ButtonC.color = new Color(255f, 255f, 255f);
        isT1Finished = true;
    }

    public void OnT1ButtonB()
    {
        t1Selection = SELECTION.UNIDENTIFIED;
        T1ButtonA.color = new Color(255f, 255f, 255f);
        T1ButtonB.color = new Color(0, 255f, 0);
        T1ButtonC.color = new Color(255f, 255f, 255f);
        isT1Finished = true;
    }

    public void OnT1ButtonC()
    {
        t1Selection = SELECTION.NO;
        T1ButtonA.color = new Color(255f, 255f, 255f);
        T1ButtonB.color = new Color(255f, 255f, 255f);
        T1ButtonC.color = new Color(0, 255f, 0);
        isT1Finished = true;
    }

    public void OnT2ButtonA()
    {
        t2Selection = SELECTION.YES;
        T2ButtonA.color = new Color(0, 255f, 0);
        T2ButtonB.color = new Color(255f, 255f, 255f);
        T2ButtonC.color = new Color(255f, 255f, 255f);
        isT2Finished = true;
    }

    public void OnT2ButtonB()
    {
        t2Selection = SELECTION.UNIDENTIFIED;
        T2ButtonA.color = new Color(255f, 255f, 255f);
        T2ButtonB.color = new Color(0, 255f, 0);
        T2ButtonC.color = new Color(255f, 255f, 255f);
        isT2Finished = true;
    }

    public void OnT2ButtonC()
    {
        t2Selection = SELECTION.NO;
        T2ButtonA.color = new Color(255f, 255f, 255f);
        T2ButtonB.color = new Color(255f, 255f, 255f);
        T2ButtonC.color = new Color(0, 255f, 0);
        isT2Finished = true;
    }

    public void OnT3ButtonA()
    {
        t3Selection = SELECTION.YES;
        T3ButtonA.color = new Color(0, 255f, 0);
        T3ButtonB.color = new Color(255f, 255f, 255f);
        T3ButtonC.color = new Color(255f, 255f, 255f);
        isT3Finished = true;
    }

    public void OnT3ButtonB()
    {
        t3Selection = SELECTION.UNIDENTIFIED;
        T3ButtonA.color = new Color(255f, 255f, 255f);
        T3ButtonB.color = new Color(0, 255f, 0);
        T3ButtonC.color = new Color(255f, 255f, 255f);
        isT3Finished = true;
    }

    public void OnT3ButtonC()
    {
        t3Selection = SELECTION.NO;
        T3ButtonA.color = new Color(255f, 255f, 255f);
        T3ButtonB.color = new Color(255f, 255f, 255f);
        T3ButtonC.color = new Color(0, 255f, 0);
        isT3Finished = true;
    }

    public void OnT4ButtonA()
    {
        t4Selection = SELECTION.YES;
        T4ButtonA.color = new Color(0, 255f, 0);
        T4ButtonB.color = new Color(255f, 255f, 255f);
        T4ButtonC.color = new Color(255f, 255f, 255f);
        isT4Finished = true;
    }

    public void OnT4ButtonB()
    {
        t4Selection = SELECTION.UNIDENTIFIED;
        T4ButtonA.color = new Color(255f, 255f, 255f);
        T4ButtonB.color = new Color(0, 255f, 0);
        T4ButtonC.color = new Color(255f, 255f, 255f);
        isT4Finished = true;
    }

    public void OnT4ButtonC()
    {
        t4Selection = SELECTION.NO;
        T4ButtonA.color = new Color(255f, 255f, 255f);
        T4ButtonB.color = new Color(255f, 255f, 255f);
        T4ButtonC.color = new Color(0, 255f, 0);
        isT4Finished = true;
    }

    public void OnT5ButtonA()
    {
        t5Selection = SELECTION.YES;
        T5ButtonA.color = new Color(0, 255f, 0);
        T5ButtonB.color = new Color(255f, 255f, 255f);
        T5ButtonC.color = new Color(255f, 255f, 255f);
        isT5Finished = true;
    }

    public void OnT5ButtonB()
    {
        t5Selection = SELECTION.UNIDENTIFIED;
        T5ButtonA.color = new Color(255f, 255f, 255f);
        T5ButtonB.color = new Color(0, 255f, 0);
        T5ButtonC.color = new Color(255f, 255f, 255f);
        isT5Finished = true;
    }

    public void OnT5ButtonC()
    {
        t5Selection = SELECTION.NO;
        T5ButtonA.color = new Color(255f, 255f, 255f);
        T5ButtonB.color = new Color(255f, 255f, 255f);
        T5ButtonC.color = new Color(0, 255f, 0);
        isT5Finished = true;
    }

    public void OnT6ButtonA()
    {
        t6Selection = SELECTION.YES;
        T6ButtonA.color = new Color(0, 255f, 0);
        T6ButtonB.color = new Color(255f, 255f, 255f);
        T6ButtonC.color = new Color(255f, 255f, 255f);
        isT6Finished = true;
    }

    public void OnT6ButtonB()
    {
        t6Selection = SELECTION.UNIDENTIFIED;
        T6ButtonA.color = new Color(255f, 255f, 255f);
        T6ButtonB.color = new Color(0, 255f, 0);
        T6ButtonC.color = new Color(255f, 255f, 255f);
        isT6Finished = true;
    }

    public void OnT6ButtonC()
    {
        t6Selection = SELECTION.NO;
        T6ButtonA.color = new Color(255f, 255f, 255f);
        T6ButtonB.color = new Color(255f, 255f, 255f);
        T6ButtonC.color = new Color(0, 255f, 0);
        isT6Finished = true;
    }

    public void OnT7ButtonA()
    {
        t7Selection = SELECTION.YES;
        T7ButtonA.color = new Color(0, 255f, 0);
        T7ButtonB.color = new Color(255f, 255f, 255f);
        T7ButtonC.color = new Color(255f, 255f, 255f);
        isT7Finished = true;
    }

    public void OnT7ButtonB()
    {
        t7Selection = SELECTION.UNIDENTIFIED;
        T7ButtonA.color = new Color(255f, 255f, 255f);
        T7ButtonB.color = new Color(0, 255f, 0);
        T7ButtonC.color = new Color(255f, 255f, 255f);
        isT7Finished = true;
    }

    public void OnT7ButtonC()
    {
        t7Selection = SELECTION.NO;
        T7ButtonA.color = new Color(255f, 255f, 255f);
        T7ButtonB.color = new Color(255f, 255f, 255f);
        T7ButtonC.color = new Color(0, 255f, 0);
        isT7Finished = true;
    }

    public void OnT8ButtonA()
    {
        t8Selection = SELECTION.YES;
        T8ButtonA.color = new Color(0, 255f, 0);
        T8ButtonB.color = new Color(255f, 255f, 255f);
        T8ButtonC.color = new Color(255f, 255f, 255f);
        isT8Finished = true;
    }

    public void OnT8ButtonB()
    {
        t8Selection = SELECTION.UNIDENTIFIED;
        T8ButtonA.color = new Color(255f, 255f, 255f);
        T8ButtonB.color = new Color(0, 255f, 0);
        T8ButtonC.color = new Color(255f, 255f, 255f);
        isT8Finished = true;
    }

    public void OnT8ButtonC()
    {
        t8Selection = SELECTION.NO;
        T8ButtonA.color = new Color(255f, 255f, 255f);
        T8ButtonB.color = new Color(255f, 255f, 255f);
        T8ButtonC.color = new Color(0, 255f, 0);
        isT8Finished = true;
    }

    public void OnT9ButtonA()
    {
        t9Selection = SELECTION.YES;
        T9ButtonA.color = new Color(0, 255f, 0);
        T9ButtonB.color = new Color(255f, 255f, 255f);
        T9ButtonC.color = new Color(255f, 255f, 255f);
        isT9Finished = true;
    }

    public void OnT9ButtonB()
    {
        t9Selection = SELECTION.UNIDENTIFIED;
        T9ButtonA.color = new Color(255f, 255f, 255f);
        T9ButtonB.color = new Color(0, 255f, 0);
        T9ButtonC.color = new Color(255f, 255f, 255f);
        isT9Finished = true;
    }

    public void OnT9ButtonC()
    {
        t9Selection = SELECTION.NO;
        T9ButtonA.color = new Color(255f, 255f, 255f);
        T9ButtonB.color = new Color(255f, 255f, 255f);
        T9ButtonC.color = new Color(0, 255f, 0);
        isT9Finished = true;
    }

    public void OnT10ButtonA()
    {
        t10Selection = SELECTION.YES;
        T10ButtonA.color = new Color(0, 255f, 0);
        T10ButtonB.color = new Color(255f, 255f, 255f);
        T10ButtonC.color = new Color(255f, 255f, 255f);
        isT10Finished = true;
    }

    public void OnT10ButtonB()
    {
        t10Selection = SELECTION.UNIDENTIFIED;
        T10ButtonA.color = new Color(255f, 255f, 255f);
        T10ButtonB.color = new Color(0, 255f, 0);
        T10ButtonC.color = new Color(255f, 255f, 255f);
        isT10Finished = true;
    }

    public void OnT10ButtonC()
    {
        t10Selection = SELECTION.NO;
        T10ButtonA.color = new Color(255f, 255f, 255f);
        T10ButtonB.color = new Color(255f, 255f, 255f);
        T10ButtonC.color = new Color(0, 255f, 0);
        isT10Finished = true;
    }
    public void OnT11ButtonA()
    {
        t11Selection = SELECTION.YES;
        T11ButtonA.color = new Color(0, 255f, 0);
        T11ButtonB.color = new Color(255f, 255f, 255f);
        T11ButtonC.color = new Color(255f, 255f, 255f);
        isT11Finished = true;
    }

    public void OnT11ButtonB()
    {
        t11Selection = SELECTION.UNIDENTIFIED;
        T11ButtonA.color = new Color(255f, 255f, 255f);
        T11ButtonB.color = new Color(0, 255f, 0);
        T11ButtonC.color = new Color(255f, 255f, 255f);
        isT11Finished = true;
    }

    public void OnT11ButtonC()
    {
        t11Selection = SELECTION.NO;
        T11ButtonA.color = new Color(255f, 255f, 255f);
        T11ButtonB.color = new Color(255f, 255f, 255f);
        T11ButtonC.color = new Color(0, 255f, 0);
        isT11Finished = true;
    }

    public void OnT12ButtonA()
    {
        t12Selection = SELECTION.YES;
        T12ButtonA.color = new Color(0, 255f, 0);
        T12ButtonB.color = new Color(255f, 255f, 255f);
        T12ButtonC.color = new Color(255f, 255f, 255f);
        isT12Finished = true;
    }

    public void OnT12ButtonB()
    {
        t12Selection = SELECTION.UNIDENTIFIED;
        T12ButtonA.color = new Color(255f, 255f, 255f);
        T12ButtonB.color = new Color(0, 255f, 0);
        T12ButtonC.color = new Color(255f, 255f, 255f);
        isT12Finished = true;
    }

    public void OnT12ButtonC()
    {
        t12Selection = SELECTION.NO;
        T12ButtonA.color = new Color(255f, 255f, 255f);
        T12ButtonB.color = new Color(255f, 255f, 255f);
        T12ButtonC.color = new Color(0, 255f, 0);
        isT12Finished = true;
    }

    public void OnT13ButtonA()
    {
        t13Selection = SELECTION.YES;
        T13ButtonA.color = new Color(0, 255f, 0);
        T13ButtonB.color = new Color(255f, 255f, 255f);
        T13ButtonC.color = new Color(255f, 255f, 255f);
        isT13Finished = true;
    }

    public void OnT13ButtonB()
    {
        t13Selection = SELECTION.UNIDENTIFIED;
        T13ButtonA.color = new Color(255f, 255f, 255f);
        T13ButtonB.color = new Color(0, 255f, 0);
        T13ButtonC.color = new Color(255f, 255f, 255f);
        isT13Finished = true;
    }

    public void OnT13ButtonC()
    {
        t13Selection = SELECTION.NO;
        T13ButtonA.color = new Color(255f, 255f, 255f);
        T13ButtonB.color = new Color(255f, 255f, 255f);
        T13ButtonC.color = new Color(0, 255f, 0);
        isT13Finished = true;
    }

    public void OnT14ButtonA()
    {
        t14Selection = SELECTION.YES;
        T14ButtonA.color = new Color(0, 255f, 0);
        T14ButtonB.color = new Color(255f, 255f, 255f);
        T14ButtonC.color = new Color(255f, 255f, 255f);
        isT14Finished = true;
    }

    public void OnT14ButtonB()
    {
        t14Selection = SELECTION.UNIDENTIFIED;
        T14ButtonA.color = new Color(255f, 255f, 255f);
        T14ButtonB.color = new Color(0, 255f, 0);
        T14ButtonC.color = new Color(255f, 255f, 255f);
        isT14Finished = true;
    }

    public void OnT14ButtonC()
    {
        t14Selection = SELECTION.NO;
        T14ButtonA.color = new Color(255f, 255f, 255f);
        T14ButtonB.color = new Color(255f, 255f, 255f);
        T14ButtonC.color = new Color(0, 255f, 0);
        isT14Finished = true;
    }

    public void OnT15ButtonA()
    {
        t15Selection = SELECTION.YES;
        T15ButtonA.color = new Color(0, 255f, 0);
        T15ButtonB.color = new Color(255f, 255f, 255f);
        T15ButtonC.color = new Color(255f, 255f, 255f);
        isT15Finished = true;
    }

    public void OnT15ButtonB()
    {
        t15Selection = SELECTION.UNIDENTIFIED;
        T15ButtonA.color = new Color(255f, 255f, 255f);
        T15ButtonB.color = new Color(0, 255f, 0);
        T15ButtonC.color = new Color(255f, 255f, 255f);
        isT15Finished = true;
    }

    public void OnT15ButtonC()
    {
        t15Selection = SELECTION.NO;
        T15ButtonA.color = new Color(255f, 255f, 255f);
        T15ButtonB.color = new Color(255f, 255f, 255f);
        T15ButtonC.color = new Color(0, 255f, 0);
        isT15Finished = true;
    }

    public void OnT16ButtonA()
    {
        t16Selection = SELECTION.YES;
        T16ButtonA.color = new Color(0, 255f, 0);
        T16ButtonB.color = new Color(255f, 255f, 255f);
        T16ButtonC.color = new Color(255f, 255f, 255f);
        isT16Finished = true;
    }

    public void OnT16ButtonB()
    {
        t16Selection = SELECTION.UNIDENTIFIED;
        T16ButtonA.color = new Color(255f, 255f, 255f);
        T16ButtonB.color = new Color(0, 255f, 0);
        T16ButtonC.color = new Color(255f, 255f, 255f);
        isT16Finished = true;
    }

    public void OnT16ButtonC()
    {
        t16Selection = SELECTION.NO;
        T16ButtonA.color = new Color(255f, 255f, 255f);
        T16ButtonB.color = new Color(255f, 255f, 255f);
        T16ButtonC.color = new Color(0, 255f, 0);
        isT16Finished = true;
    }

    public void OnT17ButtonA()
    {
        t17Selection = SELECTION.YES;
        T17ButtonA.color = new Color(0, 255f, 0);
        T17ButtonB.color = new Color(255f, 255f, 255f);
        T17ButtonC.color = new Color(255f, 255f, 255f);
        isT17Finished = true;
    }

    public void OnT17ButtonB()
    {
        t17Selection = SELECTION.UNIDENTIFIED;
        T17ButtonA.color = new Color(255f, 255f, 255f);
        T17ButtonB.color = new Color(0, 255f, 0);
        T17ButtonC.color = new Color(255f, 255f, 255f);
        isT17Finished = true;
    }

    public void OnT17ButtonC()
    {
        t17Selection = SELECTION.NO;
        T17ButtonA.color = new Color(255f, 255f, 255f);
        T17ButtonB.color = new Color(255f, 255f, 255f);
        T17ButtonC.color = new Color(0, 255f, 0);
        isT17Finished = true;
    }

    public void OnT18ButtonA()
    {
        t18Selection = SELECTION.YES;
        T18ButtonA.color = new Color(0, 255f, 0);
        T18ButtonB.color = new Color(255f, 255f, 255f);
        T18ButtonC.color = new Color(255f, 255f, 255f);
        isT18Finished = true;
    }

    public void OnT18ButtonB()
    {
        t18Selection = SELECTION.UNIDENTIFIED;
        T18ButtonA.color = new Color(255f, 255f, 255f);
        T18ButtonB.color = new Color(0, 255f, 0);
        T18ButtonC.color = new Color(255f, 255f, 255f);
        isT18Finished = true;
    }

    public void OnT18ButtonC()
    {
        t18Selection = SELECTION.NO;
        T18ButtonA.color = new Color(255f, 255f, 255f);
        T18ButtonB.color = new Color(255f, 255f, 255f);
        T18ButtonC.color = new Color(0, 255f, 0);
        isT18Finished = true;
    }

    public void OnT19ButtonA()
    {
        t19Selection = SELECTION.YES;
        T19ButtonA.color = new Color(0, 255f, 0);
        T19ButtonB.color = new Color(255f, 255f, 255f);
        T19ButtonC.color = new Color(255f, 255f, 255f);
        isT19Finished = true;
    }

    public void OnT19ButtonB()
    {
        t19Selection = SELECTION.UNIDENTIFIED;
        T19ButtonA.color = new Color(255f, 255f, 255f);
        T19ButtonB.color = new Color(0, 255f, 0);
        T19ButtonC.color = new Color(255f, 255f, 255f);
        isT19Finished = true;
    }

    public void OnT19ButtonC()
    {
        t19Selection = SELECTION.NO;
        T19ButtonA.color = new Color(255f, 255f, 255f);
        T19ButtonB.color = new Color(255f, 255f, 255f);
        T19ButtonC.color = new Color(0, 255f, 0);
        isT19Finished = true;
    }

    public void OnT20ButtonA()
    {
        t20Selection = SELECTION.YES;
        T20ButtonA.color = new Color(0, 255f, 0);
        T20ButtonB.color = new Color(255f, 255f, 255f);
        T20ButtonC.color = new Color(255f, 255f, 255f);
        isT20Finished = true;
    }

    public void OnT20ButtonB()
    {
        t20Selection = SELECTION.UNIDENTIFIED;
        T20ButtonA.color = new Color(255f, 255f, 255f);
        T20ButtonB.color = new Color(0, 255f, 0);
        T20ButtonC.color = new Color(255f, 255f, 255f);
        isT20Finished = true;
    }

    public void OnT20ButtonC()
    {
        t20Selection = SELECTION.NO;
        T20ButtonA.color = new Color(255f, 255f, 255f);
        T20ButtonB.color = new Color(255f, 255f, 255f);
        T20ButtonC.color = new Color(0, 255f, 0);
        isT20Finished = true;
    }

    public void OnAgainButtonClick()
    {
        finalCount = 0;
        isT1Finished = false;
        isT2Finished = false;
        isT3Finished = false;
        isT4Finished = false;
        isT5Finished = false;
        isT6Finished = false;
        isT7Finished = false;
        isT8Finished = false;
        isT9Finished = false;
        isT10Finished = false;
        isT11Finished = false;
        isT12Finished = false;
        isT13Finished = false;
        isT14Finished = false;
        isT15Finished = false;
        isT16Finished = false;
        isT17Finished = false;
        isT18Finished = false;
        isT19Finished = false;
        isT20Finished = false;
        T1ButtonA.color = new Color(255f, 255f, 255f);
        T1ButtonB.color = new Color(255f, 255f, 255f);
        T1ButtonC.color = new Color(255f, 255f, 255f);
        T2ButtonA.color = new Color(255f, 255f, 255f);
        T2ButtonB.color = new Color(255f, 255f, 255f);
        T2ButtonC.color = new Color(255f, 255f, 255f);
        T3ButtonA.color = new Color(255f, 255f, 255f);
        T3ButtonB.color = new Color(255f, 255f, 255f);
        T3ButtonC.color = new Color(255f, 255f, 255f);
        T4ButtonA.color = new Color(255f, 255f, 255f);
        T4ButtonB.color = new Color(255f, 255f, 255f);
        T4ButtonC.color = new Color(255f, 255f, 255f);
        T5ButtonA.color = new Color(255f, 255f, 255f);
        T5ButtonB.color = new Color(255f, 255f, 255f);
        T5ButtonC.color = new Color(255f, 255f, 255f);
        T6ButtonA.color = new Color(255f, 255f, 255f);
        T6ButtonB.color = new Color(255f, 255f, 255f);
        T6ButtonC.color = new Color(255f, 255f, 255f);
        T7ButtonA.color = new Color(255f, 255f, 255f);
        T7ButtonB.color = new Color(255f, 255f, 255f);
        T7ButtonC.color = new Color(255f, 255f, 255f);
        T8ButtonA.color = new Color(255f, 255f, 255f);
        T8ButtonB.color = new Color(255f, 255f, 255f);
        T8ButtonC.color = new Color(255f, 255f, 255f);
        T9ButtonA.color = new Color(255f, 255f, 255f);
        T9ButtonB.color = new Color(255f, 255f, 255f);
        T9ButtonC.color = new Color(255f, 255f, 255f);
        T10ButtonA.color = new Color(255f, 255f, 255f);
        T10ButtonB.color = new Color(255f, 255f, 255f);
        T10ButtonC.color = new Color(255f, 255f, 255f);
        T11ButtonA.color = new Color(255f, 255f, 255f);
        T11ButtonB.color = new Color(255f, 255f, 255f);
        T11ButtonC.color = new Color(255f, 255f, 255f);
        T12ButtonA.color = new Color(255f, 255f, 255f);
        T12ButtonB.color = new Color(255f, 255f, 255f);
        T12ButtonC.color = new Color(255f, 255f, 255f);
        T13ButtonA.color = new Color(255f, 255f, 255f);
        T13ButtonB.color = new Color(255f, 255f, 255f);
        T13ButtonC.color = new Color(255f, 255f, 255f);
        T14ButtonA.color = new Color(255f, 255f, 255f);
        T14ButtonB.color = new Color(255f, 255f, 255f);
        T14ButtonC.color = new Color(255f, 255f, 255f);
        T15ButtonA.color = new Color(255f, 255f, 255f);
        T15ButtonB.color = new Color(255f, 255f, 255f);
        T15ButtonC.color = new Color(255f, 255f, 255f);
        T16ButtonA.color = new Color(255f, 255f, 255f);
        T16ButtonB.color = new Color(255f, 255f, 255f);
        T16ButtonC.color = new Color(255f, 255f, 255f);
        T17ButtonA.color = new Color(255f, 255f, 255f);
        T17ButtonB.color = new Color(255f, 255f, 255f);
        T17ButtonC.color = new Color(255f, 255f, 255f);
        T18ButtonA.color = new Color(255f, 255f, 255f);
        T18ButtonB.color = new Color(255f, 255f, 255f);
        T18ButtonC.color = new Color(255f, 255f, 255f);
        T19ButtonA.color = new Color(255f, 255f, 255f);
        T19ButtonB.color = new Color(255f, 255f, 255f);
        T19ButtonC.color = new Color(255f, 255f, 255f);
        T20ButtonA.color = new Color(255f, 255f, 255f);
        T20ButtonB.color = new Color(255f, 255f, 255f);
        T20ButtonC.color = new Color(255f, 255f, 255f);
    }
}

   
    
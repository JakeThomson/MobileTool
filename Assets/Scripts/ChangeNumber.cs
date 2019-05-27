using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeNumber : MonoBehaviour
{
    public Text textShowed = null;

    public void IncreaseNumber()
    {
        switch (textShowed.text)
        {
            case "0":
                textShowed.text = "1";
                break;
            case "1":
                textShowed.text = "2";
                break;
            case "2":
                textShowed.text = "3";
                break;
            case "3":
                textShowed.text = "4";
                break;
            case "4":
                textShowed.text = "5";
                break;
            case "5":
                textShowed.text = "6";
                break;
            case "6":
                textShowed.text = "7";
                break;
            case "7":
                textShowed.text = "8";
                break;
            case "8":
                textShowed.text = "9";
                break;
            case "9":
                textShowed.text = "0";
                break;
            default:
                textShowed.text = "0";
                break;
        }
        return;
    }

    public void DecreaseNumber()
    {
        switch (textShowed.text)
        {
            case "0":
                textShowed.text = "9";
                break;
            case "1":
                textShowed.text = "0";
                break;
            case "2":
                textShowed.text = "1";
                break;
            case "3":
                textShowed.text = "2";
                break;
            case "4":
                textShowed.text = "3";
                break;
            case "5":
                textShowed.text = "4";
                break;
            case "6":
                textShowed.text = "5";
                break;
            case "7":
                textShowed.text = "6";
                break;
            case "8":
                textShowed.text = "7";
                break;
            case "9":
                textShowed.text = "8";
                break;
            default:
                textShowed.text = "0";
                break;
        }
        return;
    }
}

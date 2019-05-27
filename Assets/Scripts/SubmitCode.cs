using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SubmitCode : MonoBehaviour
{
    public Text digit1 = null;
    public Text digit2 = null;
    public Text digit3 = null;
    public Text digit4 = null;
    public Text incorrectText = null;
    public GameObject correctBackground;
    public Text correctText = null;
    public Color correctColor;
    public Color incorrectColor;

    public void passcodeConfirmation()
    {
        if(string.Equals(digit1.text, "1") && string.Equals(digit2.text, "9") && string.Equals(digit3.text, "5") && string.Equals(digit4.text, "8"))
        {
            correctBackground.SetActive(true);
            StartCoroutine(Wait(2.5f));
        }
        else
        {
            incorrectText.text = "PASSCODE INCORRECT";
            incorrectText.color = incorrectColor;
        }
        return;
    }

    IEnumerator Wait(float secs)
    {
        yield return new WaitForSeconds(secs);
        SceneManager.LoadScene("01.intro", LoadSceneMode.Single);
    }
}

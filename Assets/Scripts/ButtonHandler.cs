using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public GameObject image;
    public string sceneName;
    public GameObject thisDia;
    public GameObject nextDia;

    public void ToggleImage()
    {
        if(image.active)
        {
            image.SetActive(false);
        }
        else
        {
            image.SetActive(true);
        }
        return;
    }

    public void NextText()
    {
        thisDia.SetActive(false);
        nextDia.SetActive(true);
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void ShiftRight()
    {
        for(int i=0; i<12; i++)
        {
            StartCoroutine(Wait(0.0001f, -1));
        }
            image.transform.Rotate(0,0, -1.846153846153846153846153846154f);
    }

    public void ShiftLeft()
    {
        for (int i = 0; i < 12; i++)
        {
            StartCoroutine(Wait(0.0001f, 1));
        }
        image.transform.Rotate(0, 0, 1.846153846153846153846153846154f);
    }

    IEnumerator Wait(float secs, int deg)
    {
        yield return new WaitForSeconds(secs);
        image.transform.Rotate(0, 0, deg);
    }
}

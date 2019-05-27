using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeButton : MonoBehaviour
{
    public GameObject image;

    private void OnMouseDown()
    {
        if(image.active)
        {
            image.SetActive(false);
        }
        else
        {
            image.SetActive(true);
        }
    }
}

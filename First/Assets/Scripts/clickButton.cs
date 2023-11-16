using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickButton : MonoBehaviour
{
    public GameObject obj;
 
    public void OnClick()
    {
        if (obj.activeSelf)
        {
            obj.SetActive(false);
        }
        else
        {
            obj.SetActive(true);
        }
    } 
}

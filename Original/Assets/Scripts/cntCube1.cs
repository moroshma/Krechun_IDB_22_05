using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cntCube1 : MonoBehaviour
{


    
    
    public Text CubeCntCol1;

    



    void Update()
    {
        
        CubeCntCol1.text = (trigerCollision.cnt).ToString();

    }
}

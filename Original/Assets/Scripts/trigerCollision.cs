using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigerCollision : MonoBehaviour
{
    public static int cnt = 1000;
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "quest2")
        {
            transform.position = transform.position + new Vector3(0, 1f, 0);
            cnt--;
        }
    }
}

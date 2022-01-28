using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knives : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<bird>() != null)
        {
            evilwizard.instance.turtleScored();
        }
    }
}

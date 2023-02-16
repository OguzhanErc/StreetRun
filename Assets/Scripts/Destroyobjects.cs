using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyobjects : MonoBehaviour
{

    public void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.CompareTag("Untagged")|| hit.gameObject.CompareTag("Obstacles"))
        {
            gameObject.SetActive(false);
        }
    }




}

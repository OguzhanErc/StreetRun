using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Shake : MonoBehaviour
{
    private bool shakecontrol = false;
    public IEnumerator CameraShakes(float duration,float magnitude)
    {
        Vector3 orginalPos = transform.localPosition;

        float elapsed = 0.0f;

        while(elapsed < duration)
        {
            float x = Random.Range(-1f, 1f* magnitude);
            float y = Random.Range(-1f, 1f* magnitude);

            transform.localPosition = new Vector3(x, y, orginalPos.z);

            elapsed+= Time.deltaTime;
            yield return null;
        }
        transform.localPosition = orginalPos;

       
    }

    public void CameraShakesCall()
    {
        if(shakecontrol==false)
        {
            StartCoroutine(CameraShakes(0.22f, .4f));
        }
        shakecontrol = true;

    }

}

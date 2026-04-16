using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;


public class cameraFollow : MonoBehaviour
{
    public Transform target;

    public float layer;

    public float lerpSpeed;

    public float sizeSpeed;

    public float cameraSize;

    public float newCameraSize;

    float currentSize = 7.5f;

    private void FixedUpdate()
    {
        Vector3 targetPos = new Vector3(target.position.x, target.position.y, layer);

        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * lerpSpeed);

        if (currentSize > newCameraSize)
        {
            currentSize = currentSize - sizeSpeed;
        }
        else if (currentSize != newCameraSize)
        {

            currentSize = currentSize + sizeSpeed;
        }


        GetComponent<Camera>().orthographicSize = currentSize;
    }

}

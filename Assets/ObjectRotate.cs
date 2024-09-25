using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObjectRotate : MonoBehaviour
{
    public float rotateSpeed = 100;
    public Transform rotateAround;

    private bool isClockwise = true;



    void Update()
    {
        float rotationAmount = rotateSpeed * Time.deltaTime;
        if (!isClockwise)
        {
            rotationAmount = -rotationAmount;
        }

        if (rotateAround != null)
        {
            transform.RotateAround(rotateAround.position, Vector3.forward, rotationAmount);
        }

        // Check if the space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ToggleRotationDirection();
        }
     
    }

    void ToggleRotationDirection()
    {
        // Toggle the direction
        isClockwise = !isClockwise;
    }

}




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotate : MonoBehaviour
{
    [SerializeField] public float rotateSpeed = 1;
    [SerializeField] private Transform rotateAround;

    private bool autoRotate = false;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ToggleAutoRotate();
        }

        if (autoRotate)
        {
            this.transform.RotateAround(rotateAround.position, Vector3.forward, rotateSpeed * Time.deltaTime);
            this.transform.Rotate(Vector3.forward, -rotateSpeed * Time.deltaTime);
        }
    }

    

    private void ToggleAutoRotate()
    {
        this.autoRotate = !this.autoRotate;
    }
}

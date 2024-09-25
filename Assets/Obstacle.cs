using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject Wall;
    public GameObject CollectEnd;
    public float speed;

    private void OnTriggerEnter(Collider Ball)
    {
        if (Ball.gameObject.CompareTag("Player"))
        {
            Destroy(Ball.gameObject);
            Application.Quit();
           
        }
    }

    void Update()
    {
        Wall.transform.position = Vector3.MoveTowards(Wall.transform.position, CollectEnd.transform.position, speed);
    }
}

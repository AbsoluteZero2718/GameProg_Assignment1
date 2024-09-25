using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
   public GameObject CollectEnd;
   public GameObject Diamond;
   public float speed;

    
   void Update()
    {
        Diamond.transform.position = Vector3.MoveTowards(Diamond.transform.position, CollectEnd.transform.position, speed);
    }
}

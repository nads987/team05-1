using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public ConnectionsDisplay display;
    //void OnCollisionEnter(Collision collision)
    //{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Do something

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Good")
        {
            display.connections++;
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Good connection");
           
            collision.gameObject.transform.parent = gameObject.transform;
        }
        if (collision.gameObject.tag == "Bad")
        {
            display.connections--;
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Bad connection");
        }
    }
    //}
}

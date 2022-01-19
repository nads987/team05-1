using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{
    public CollisionDetection spheres;
    public ConnectionsDisplay display;
   //public Color currColor;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //Do something
        // collision.GetComponent<SpriteRenderer>().color = currColor;
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Good")
        {
            //collision.GetComponent<SpriteRenderer>().color = currColor;
            display.connections++;
            Destroy(collision.gameObject, 0.02f);
            spheres.AddCircle();
            //If the GameObject has the same tag as specified, output this message in the console
           // Debug.Log("Good connection");


        }
        if (collision.gameObject.tag == "Bad")
        {
            display.connections--;
            Destroy(collision.gameObject, 0.02f);
            //spheres.RemoveCircle();
            //If the GameObject has the same tag as specified, output this message in the console
            //Debug.Log("Bad connection");
        }
    }
}

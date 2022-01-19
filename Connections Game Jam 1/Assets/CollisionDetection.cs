using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    
    public Transform sphere;
    public float circleDiameter;
    private List<Transform> spheres = new List<Transform>();
    private List<Vector2> positions = new List<Vector2>();
    private void Start()
    {
        positions.Add(sphere.position);
    }
    private void Update()
    {
        float distance = ((Vector2)sphere.position - positions[0]).magnitude;
        if(distance > circleDiameter)
        {
            Vector2 direction = ((Vector2)sphere.position - positions[0]).normalized;

            positions.Insert(0, positions[0] + direction * circleDiameter);
            positions.RemoveAt(positions.Count - 1);
            distance -= circleDiameter;
        }

        for(int i=0;i<spheres.Count;i++)
        {
            spheres[i].position = Vector2.Lerp(positions[i + 1], positions[i], distance / circleDiameter);
        }
    }
    public void AddCircle()
    {
        Transform circle = Instantiate(sphere, positions[positions.Count - 1], Quaternion.identity, transform);
        //circle.GetComponent<SpriteRenderer>().color = currColor;
        spheres.Add(circle);
        positions.Add(circle.position);
    }
    public void RemoveCircle()
    {
        //Transform circle = Instantiate(sphere, positions[positions.Count - 1], Quaternion.identity, transform);

       // spheres.RemoveAt(spheres.Count-1);
        //positions.RemoveAt(spheres.Count-1);
    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    //Do something

    //    //Check for a match with the specific tag on any GameObject that collides with your GameObject
    //    if (collision.gameObject.tag == "Good")
    //    {
    //        display.connections++;
    //        Destroy(collision.gameObject, 0.02f);
    //        sphere.AddCircle();
    //        //If the GameObject has the same tag as specified, output this message in the console
    //        Debug.Log("Good connection");

    //        collision.gameObject.transform.parent = gameObject.transform;
    //    }
    //   
    //}
    //}
}

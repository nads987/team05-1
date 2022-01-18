using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//script to move spehres and destory them when out of bounds
public class ConnectionSphere : MonoBehaviour
{
    public float speed = 3f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Random.Range(-speed, speed), Random.Range(-speed,speed));
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > -screenBounds.x *2 && transform.position.x < screenBounds.x *2)
        {
           
        }
        else
        {
            Destroy(this.gameObject);
        }
        if (transform.position.y > -screenBounds.y *2 && transform.position.y < screenBounds.y * 2)
        {

        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}

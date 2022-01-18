using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//spawns the good connection spheres
public class SpawnGood : MonoBehaviour
{
    public GameObject spherePrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    private Color currColor;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(Wave());
    }
    private void Spawn()
    {
        int colorInt = Random.Range(1, 6);
        if (colorInt == 1)
        {
            currColor = Color.red;
        }
        else if (colorInt == 2)
        {
            currColor = Color.blue;
        }
        else if (colorInt == 3)
        {

            currColor = Color.yellow;

        }
        else if (colorInt == 4)
        {

            currColor = Color.green;
        }
        else if (colorInt == 5)
        {

            currColor = Color.magenta;
        }
        GameObject a = Instantiate(spherePrefab) as GameObject;
        a.GetComponent<SpriteRenderer>().color = currColor;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x * 1.5f, screenBounds.x * 1.5f), Random.Range(-screenBounds.y * 1.5f, screenBounds.y * 1.5f));
    }
   
    IEnumerator Wave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            Spawn();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBad : MonoBehaviour
{
    public GameObject spherePrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(Wave());
    }
    private void Spawn()
    {
        GameObject a = Instantiate(spherePrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x*1.5f, screenBounds.x * 1.5f), Random.Range(-screenBounds.y * 1.5f, screenBounds.y * 1.5f));
    }
    // Update is called once per frame
    //void Update()
    //{

    //}
    IEnumerator Wave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            Spawn();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class Select : MonoBehaviour
{
    SpriteRenderer MainSpriteRenderer;
    public Sprite Standby;
    public Sprite Hold;

    // Start is called before the first frame update
    void Start()
    {
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //マウスが乗った時
    void OnMouseEnter()
    {
        MainSpriteRenderer.sprite = Hold;
    }


    //マウスが離れたとき
    void OnMouseExit()
    {
        MainSpriteRenderer.sprite = Standby;
    }
}

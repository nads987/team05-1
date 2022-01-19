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

    //�}�E�X���������
    void OnMouseEnter()
    {
        MainSpriteRenderer.sprite = Hold;
    }


    //�}�E�X�����ꂽ�Ƃ�
    void OnMouseExit()
    {
        MainSpriteRenderer.sprite = Standby;
    }
}

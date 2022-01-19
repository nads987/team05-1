using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title_Exit : MonoBehaviour
{

    SpriteRenderer MainSpriteRenderer;
    public Sprite Standby;
    public Sprite Hold;
    static bool NowSelect;
    static float value;

    // Start is called before the first frame update
    void Start()
    {
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        NowSelect = false;
        value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        value = Input.GetAxisRaw("Vertical");

        if (value <= -0.1)
        {
            ShowUI();
        }
        else if (value >= 0.1)
        {
            HideUI();
        }

        if (NowSelect == true && Input.GetKeyDown(KeyCode.JoystickButton0) || NowSelect == true && Input.GetKeyDown(KeyCode.Return))
        {
            Quit();
        }
    }

    void OnMouseEnter()
    {
        ShowUI();
    }

    void OnMouseExit()
    {
        HideUI();
    }

    void OnMouseDown()
    {
        if (NowSelect == true)
        {
            Quit();
        }
    }

    void ShowUI()
    {
        if (value >= 0.1)
        {
            NowSelect = false;
        }
        else
        {
            NowSelect = true;
        }
        MainSpriteRenderer.sprite = Hold;
    }

    void HideUI()
    {
        if (value <= -0.1)
        {
            NowSelect = true;
        }
        else
        {
            NowSelect = false;
        }
        MainSpriteRenderer.sprite = Standby;
    }

    void Quit()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_STANDALONE
        UnityEngine.Application.Quit();
        #endif
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title_Start : MonoBehaviour
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

        if (value >= 0.1)
        {
            ShowUI();
        }
        else if (value <= -0.1)
        {
            HideUI();
        }

        if(NowSelect == true && Input.GetButtonDown("Jump") || NowSelect == true && Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            SceneManager.LoadScene("MainScene");
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
        if(NowSelect == true)
        {
            SceneManager.LoadScene("MainScene");
        }
    }

    void ShowUI()
    {
        if (value <= -0.1)
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
        if (value >= 0.1)
        {
            NowSelect = true;
        }
        else
        {
            NowSelect = false;
        }
        MainSpriteRenderer.sprite = Standby;
    }
}

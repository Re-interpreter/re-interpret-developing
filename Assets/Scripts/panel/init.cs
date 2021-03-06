﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.scene.name == "mainScene")
        {
            //UIManager.Instance.PushPanel(UIPanelType.begin);
            //transform.Find("beginPanel(Clone)").Find("Text").gameObject.SetActive(false);
            Invoke("OnActive", 2.1f);
            //AudioManager.Instance.PlayMusic("test");
            AudioManager.Instance.PlayMusic("Music/mainScene");
            AudioManager.Instance.changeMusicVolume(0.5f * settingMessage.Instance.getMusicVolume());
        }
        else if (gameObject.scene.name == "fightGame")
        {
            UIManager.Instance.PushPanel(UIPanelType.fightSelectPart);
        }
        else if (gameObject.scene.name == "storyGame")
        {
            UIManager.Instance.PushPanel(UIPanelType.storyMain);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnActive()
    {
        //transform.Find("beginPanel(Clone)").Find("Text").gameObject.SetActive(true);
        UIManager.Instance.PushPanel(UIPanelType.begin);
    }
}

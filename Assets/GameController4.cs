using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class GameController4 : Singleton<GameController>
{
    [SerializeField] GameObject Player;

    public GameObject TextLevel;
    public TextMeshProUGUI TextCount;

    private int timer = 0;

    private void Start()
    {
        StartAction();
    }
    public void StartAction()
    {
        timer = 5;
        TextCount.text = timer.ToString();
        TextLevel.SetActive(true);
        StartCoroutine(CoroutineDelayAction());
    }

    IEnumerator CoroutineDelayAction()
    {
        for (int i = timer; i > 0; i--)
        {
            yield return new WaitForSeconds(1f);
            TextCount.text = i.ToString();
        }
        TextLevel.SetActive(false);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public int countdownTime;
    public Text countdownText;

    private void Start()
    {
        StartCoroutine(CountdownToStart());
    }
    IEnumerator CountdownToStart()
    {
        Time.timeScale = 0;
        while (countdownTime > 0)
        {
            countdownText.text = countdownTime.ToString();
            yield return new WaitForSecondsRealtime(1f);
            countdownTime--;
        }
        Time.timeScale = 1;
        countdownText.text = "GO!";
        yield return new WaitForSecondsRealtime(1f);

        countdownText.gameObject.SetActive(false);
    }
}
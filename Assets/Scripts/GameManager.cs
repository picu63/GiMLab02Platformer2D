using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int pointsToWin = 5;
    public Text pointsText;
    public Text timeLeftText;
    public Text endGameText;
    public int maxTime = 30;
    public int currentPoints;
    public int timeLeft;
    // Update is called once per frame
    private void Awake()
    {
        timeLeft = maxTime;
        StartCoroutine(Countdown());
    }

    void Update()
    {
        if (currentPoints >= pointsToWin)
        {
            StartCoroutine(WinGame());
        }

        if (timeLeft <= 0)
        {
            StartCoroutine(LostGame());
        }

        pointsText.text = "Punkty: " + currentPoints;
    }

    private IEnumerator WinGame()
    {
        endGameText.text = "Wygrana!";
        yield return new WaitForSeconds(1);
        RestartGame();
    }

    private IEnumerator LostGame()
    {
        endGameText.text = "Przegrałeś";
        yield return new WaitForSeconds(1);
        RestartGame();
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        currentPoints = 0;
    }

    private IEnumerator Countdown()
    {
        while (true)
        {
            timeLeft--;
            timeLeftText.text = "Pozostały czas:" + timeLeft;
            yield return new WaitForSeconds(1);
        }
    }
}

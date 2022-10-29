using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float TimerLeft;
    public bool TimerOn = false;

    public Text TimerUI;

    public Text GameoverUI;

    public Health PlayerHP;
    public Health EnemyHP;

    public Text WinLoseUI;

    // Start is called before the first frame update
    void Start()
    {
        TimerOn = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (TimerOn)
        {
            if (TimerLeft > 0)
            {
                TimerLeft -= Time.deltaTime;
                UpdateTimer(TimerLeft);
            }

            else
            {
                TimerLeft = 0;
                TimerOn = false;
                GameoverUI.enabled = true;
                GameoverUI.text = "GAME OVER";
                WinLoseUI.enabled = true;
                GameOver();
            }
        }
    }

    void UpdateTimer( float currentTime )
    {
        currentTime += 1;

        float min = Mathf.FloorToInt(currentTime / 60);
        float sec = Mathf.FloorToInt(currentTime % 60);

        TimerUI.text = string.Format("{0:00} : {1:00}", min, sec);
    }

    public void GameOver()
    {
        var player_points = PlayerHP.GetComponent<Health>();
        var enemy_points = EnemyHP.GetComponent<Health>();

        if (player_points.currentHP > enemy_points.currentHP)
        {
            WinLoseUI.text = "YOU WON";
        }

        else if (player_points.currentHP < enemy_points.currentHP)
        {
            WinLoseUI.text = "YOU LOST";
        }

        else
        {
            WinLoseUI.text = "ISSA DRAW";
        }
    }
}

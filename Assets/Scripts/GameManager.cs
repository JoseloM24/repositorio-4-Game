using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnTime = 1.5f;
    public float time = 0.0f;
    public float totaltime = 0.0f;
    public Player player;
    public TextMeshProUGUI liveText;
    public TextMeshProUGUI shieldsText;
    public TextMeshProUGUI weaponText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timeText;

    public int score = 0;


    // Update is called once per frame
    void Update()
    {
        CreateEnemy();
        UpdateCanvas();
        totaltime += Time.deltaTime;
    }

    void UpdateCanvas()
    {
        liveText.text = "life: " + player.lives;
        shieldsText.text = "shields: " + player.shields;
        weaponText.text = "weapon: " + player.BulletPref.name;
        scoreText.text = "score: " + score.ToString();
        //truncate the time to no show decimals
        timeText.text = "time: " + totaltime.ToString ("F0");

    }
    private void CreateEnemy()
    {
        time += Time.deltaTime;
        if (time > spawnTime)
        {
            Instantiate(enemyPrefab, new Vector3(Random.Range(-8.0f, 8.0f), 7.0f, 0), Quaternion.identity);
            time = 0.0f;
        }
    }
    public void AddScore(int value)
    {
        score += value;
    }
}

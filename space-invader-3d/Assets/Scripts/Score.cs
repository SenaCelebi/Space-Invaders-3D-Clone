using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI textScore;
    public TextMeshProUGUI textKills;
    public TextMeshProUGUI textHealth;

    public GameObject text;
    public GameObject button;

    public GameObject player;
    public static Score Instance { get; private set; }
   
    public int score = 0;
    public int totalEnemy = 36;
    public int totalHealth = 3;

    private void Awake()
    {
        Instance = this;
    }


    void Update()
    {
        textScore.text = "Score: " + score.ToString();
        textKills.text = "Kills: " + totalEnemy.ToString();
        textHealth.text = "Health: " + totalHealth.ToString();
        if (totalEnemy == 0)
        {
            //Win UI
        }

        if(totalHealth == 0)
        {
            Destroy(player);
            text.SetActive(true);
            button.SetActive(true);

        }


    }
}

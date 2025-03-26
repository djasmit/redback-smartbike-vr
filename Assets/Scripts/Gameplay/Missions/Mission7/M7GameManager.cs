using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M7GameManager : MonoBehaviour
{
    public int score;
    public static M7GameManager inst;

    public Text scoreText;
    public Text speedText;

    public PlayMove playmove;
    public RoadSpawner roadSpawner;
    public PlayerController player;

    public void IncreaseScore()
    {
        score++;
        scoreText.text = "Score: " + score;
        playmove.maxSpeed += playmove.speedIncreasePerPoint;
    }

    private void Awake()
    {
        inst = this;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null) { player = FindObjectOfType<PlayerController>(); }
        if (roadSpawner != null && player != null && roadSpawner.playerTransform != null)
        {
            roadSpawner.playerTransform = player;
        }
        //speedText.text = $"Speed: {playmove.currentSpeed:F1}"; //broken
    }
}

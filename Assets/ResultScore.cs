using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResultScore : MonoBehaviour
{
    public TMP_Text currentScore;
    public TMP_Text highScore;
    // Start is called before the first frame update
    void Start()
    {
        currentScore.SetText($"Score:{ScoreManager.currentScore}");
        highScore.SetText($"HighScore:{ScoreManager.HighScore}");
    }

    // Update is called once per frame
    void Update()
    {

    }
}

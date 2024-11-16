using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text highScore;
    private TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        highScore.SetText($"HightScore:{ScoreManager.HighScore}");
        text.SetText($"Score:{ScoreManager.currentScore}");
    }
}

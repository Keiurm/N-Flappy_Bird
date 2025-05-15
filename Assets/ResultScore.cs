using TMPro;
using UnityEngine;

public class ResultScore : MonoBehaviour
{
    public TMP_Text currentScore;
    public TMP_Text highScore;

    public TMP_Text[] ranksTexts;


    // Start is called before the first frame update
    void Start()
    {
        currentScore.SetText($"Score:{ScoreManager.currentScore}");
        highScore.SetText($"HighScore:{ScoreManager.highScore}");

        for (int i = 0; i < ScoreManager.ranks.Length; i++)
        {
            ranksTexts[i].SetText($"{i + 1}. {ScoreManager.ranks[i]}");
        }
    }

}

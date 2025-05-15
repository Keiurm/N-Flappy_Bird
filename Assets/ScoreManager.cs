using UnityEngine;

public class ScoreManager
{
    public static int currentScore;

    public static int highScore;

    public static int[] ranks;

    [RuntimeInitializeOnLoadMethod]
    private static void Initialize()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);

        ranks = new int[10];

        for (int i = 0; i < ranks.Length; i++)
        {
            ranks[i] = PlayerPrefs.GetInt($"Ranks_{i}", 0);
        }
        BubbleSort(ranks);
    }

    private static void BubbleSort(int[] array)
    {
        var flag = true;
        int endSortCount = 0;
        while (flag)
        {
            flag = false;
            for (int i = array.Length - 1; i > endSortCount; i--)
            {
                if (array[i] > array[i - 1])
                {
                    int temp = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = temp;
                    flag = true;
                }
            }
            endSortCount++;
        }

        for (int i = 0; i < array.Length; i++)
        {
            PlayerPrefs.SetInt($"Ranks_{i}", ranks[i]);
        }
    }
    public static void SubmitScore()
    {
        if (ranks[ranks.Length - 1] < currentScore)
        {
            ranks[ranks.Length - 1] = currentScore;
            BubbleSort(ranks);
        }
    }
    public static void SetScoere(int score)
    {
        currentScore = score;
        if (highScore < currentScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }

}

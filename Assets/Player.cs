using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpPower = 5;
    public Score score;
    public GameObject gameOver;
    private Rigidbody rb;
    private Vector3 jumpPos;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpPos = new Vector3(0, jumpPower, 0);
        gameOver.SetActive(false);
        ScoreManager.currentScore = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = jumpPos;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        ScoreManager.currentScore++;
        if (ScoreManager.HighScore < ScoreManager.currentScore)
        {
            ScoreManager.HighScore = ScoreManager.currentScore;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        gameOver.SetActive(true);
    }
}

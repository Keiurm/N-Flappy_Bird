using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    public float jumpPower = 5;
    private Rigidbody rb;
    private Vector3 jumpPos;
    public Score score;

    public GameObject gameOver;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpPos = new Vector3(0, jumpPower, 0);
        gameOver.SetActive(false);
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
        score.ScoreValue++;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        gameOver.SetActive(true);
    }
}



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
        ScoreManager.SetScoere(0);

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
        ScoreManager.SetScoere(ScoreManager.currentScore + 1);
    }

    private void OnCollisionEnter(Collision collision)
    {
        ScoreManager.SubmitScore();
        Destroy(gameObject);
        gameOver.SetActive(true);
    }
}

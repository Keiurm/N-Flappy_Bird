using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject wall;
    public float spantime;

    void Start()
    {
        StartCoroutine(SpawnWall());
    }

    // Update is called once per frame
    private IEnumerator SpawnWall()
    {
        while (true)
        {
            yield return new WaitForSeconds(spantime);
            float y = Random.Range(-500, 500);
            Instantiate(wall, new Vector3(10, y / 100, 0), Quaternion.identity);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum Scene
{
    Titile,
    InGame,
    Result
}

public class SceneChange : MonoBehaviour
{
    public Scene scene;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(scene.ToString());
        }
    }
}

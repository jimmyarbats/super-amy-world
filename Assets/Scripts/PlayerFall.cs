using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFall : MonoBehaviour
{
    public float minHeight = -15f;

    private void Update()
    {
        if (transform.position.y < minHeight)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene(2);
    }
}

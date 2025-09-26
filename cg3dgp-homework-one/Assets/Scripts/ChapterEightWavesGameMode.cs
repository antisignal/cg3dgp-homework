using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChapterEightWavesGameMode : MonoBehaviour
{
    [SerializeField] ChapterSevenLife playerLife;
    [SerializeField] ChapterSevenLife playerBaseLife;
    // Start is called before the first frame update
    void Start()
    {
        playerLife.onDeath.AddListener(OnPlayerOrBaseDied);
        playerBaseLife.onDeath.AddListener(OnPlayerOrBaseDied);
        ChapterEightEnemiesManager.instance.onChanged.AddListener(CheckWinCondition);
        ChapterEightWavesManager.instance.onChanged.AddListener(CheckWinCondition);

    }

    void Awake()
    {
        
    }
    void OnPlayerOrBaseDied()
    {
        SceneManager.LoadScene("ChapterEightLoseScene");
    }

    // Update is called once per frame
    public void CheckWinCondition()
    {
        if (ChapterEightEnemiesManager.instance.enemies.Count <= 0 &&
        ChapterEightWavesManager.instance.waves.Count <= 0)
        {
            SceneManager.LoadScene("ChapterEightWinScene");
        }
        /* if (playerLife.amount <= 0) {
            SceneManager.LoadScene("ChapterEightLoseScene");
        } */
    }
}

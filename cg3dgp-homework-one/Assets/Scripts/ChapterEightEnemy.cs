using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChapterEightEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ChapterEightEnemiesManager.instance.enemies.Add(this);
        ChapterEightEnemiesManager.instance.AddEnemy(this);
    }
    void OnDestroy()
    {
        // ChapterEightEnemiesManager.instance.enemies.Remove(this);
        ChapterEightEnemiesManager.instance.RemoveEnemy(this);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChapterEightEnemiesManager : MonoBehaviour
{
    public static ChapterEightEnemiesManager instance;
    // Start is called before the first frame update
    public List<ChapterEightEnemy> enemies;
    public UnityEvent onChanged;
    void Start()
    {
        
    }
    public void AddEnemy(ChapterEightEnemy enemy)
    {
        enemies.Add(enemy);
        onChanged.Invoke();
    }
    public void RemoveEnemy(ChapterEightEnemy enemy)
    {
        enemies.Remove(enemy);
        onChanged.Invoke();
    }
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogError("Duplicated EnemiesManager, ignoring this one", gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

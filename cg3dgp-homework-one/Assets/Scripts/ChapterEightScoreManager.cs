using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChapterEightScoreManager : MonoBehaviour
{
    public static ChapterEightScoreManager instance;
    public int amount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogError("Duplicated ScoreManager, ignoring this one", gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

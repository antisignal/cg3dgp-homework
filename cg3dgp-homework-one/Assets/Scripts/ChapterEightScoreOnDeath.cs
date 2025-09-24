using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChapterEightScoreOnDeath : MonoBehaviour
{
    public int amount;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Awake()
    {
        var life = gameObject.GetComponent<ChapterSevenLife>();
        life.onDeath.AddListener(GivePoints);
    }

    // Update is called once per frame
    
    void OnDestroy()
    {
        var life = gameObject.GetComponent<ChapterSevenLife>();
        life.onDeath.RemoveListener(GivePoints);
    }
    void GivePoints()
    {
        ChapterEightScoreManager.instance.amount += amount;
    }
}

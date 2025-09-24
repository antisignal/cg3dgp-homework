using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChapterEightWaveSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float startTime;
    public float endTime;
    public float spawnRate;
    // Start is called before the first frame update
    private void Start()
    {
        ChapterEightWavesManager.instance.AddWave(this);
        InvokeRepeating("Spawn", startTime, spawnRate);
        Invoke("EndSpawner", endTime);
    }
    void Spawn()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
    void EndSpawner()
    {
        ChapterEightWavesManager.instance.RemoveWave(this);
        CancelInvoke();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

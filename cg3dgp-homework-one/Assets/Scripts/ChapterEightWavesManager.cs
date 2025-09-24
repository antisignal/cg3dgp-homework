using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChapterEightWavesManager : MonoBehaviour
{
    public static ChapterEightWavesManager instance;
    public List<ChapterEightWaveSpawner> waves;
    public UnityEvent onChanged;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogError("Duplicated WavesManager", gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AddWave(ChapterEightWaveSpawner wave)
    {
        waves.Add(wave);
        onChanged.Invoke();
    }
    public void RemoveWave(ChapterEightWaveSpawner wave)
    {
        waves.Remove(wave);
        onChanged.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

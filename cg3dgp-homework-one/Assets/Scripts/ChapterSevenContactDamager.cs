using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChapterSevenContactDamager : MonoBehaviour
{
    public float damage;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        ChapterSevenLife life = other.GetComponent<ChapterSevenLife>();
        if (life != null)
        {
            life.amount -= damage;
        }
    }
}

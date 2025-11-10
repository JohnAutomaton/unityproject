using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject enemy;
     public GameObject enemytwo;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Createenemy", 1, 2);
        InvokeRepeating("Createenemytwo", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void Createenemy()
    {
        Instantiate(enemy, new Vector3(Random.Range(-9f, 9f), 6.5f, 0), Quaternion.identity);
    }
}
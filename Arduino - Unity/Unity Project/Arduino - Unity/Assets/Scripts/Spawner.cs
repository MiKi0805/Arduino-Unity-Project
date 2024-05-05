using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject obstacle;

    public float time_between_spawn_min = 2;
    public float time_between_spawn_max = 5;

    float countdown = 3;

    void Update()
    {
        if (countdown <= 0) 
        {
            Instantiate(obstacle, transform.position, Quaternion.identity);
            countdown = Random.Range(time_between_spawn_min, time_between_spawn_max);
        }
        else
        {
            countdown -= 1 * Time.deltaTime;
        }
        
        
    }
}

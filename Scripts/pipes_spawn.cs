using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pipes_spawn : MonoBehaviour {
    
    public GameObject pipe;
    
    private float timeBtwSpawn;
    public float StartTimeBtwSpawn;
    private Vector3 SpawnPos;
    float yPos;

    void Update(){
        yPos = Randon.Range(-3.32f, 2.17f);
        SpawnPos new Vector3(transform.position.x, ypos, transform.position.z);
        if(timeBtwSpawn<0)
        {
            Instantiate(pipe,SpawnPos,transform.rotation);
            timeBtwSpawn = StartTimeBtwSpawn;
        }
        else {
            timeBtwSpawn -= Time.deltaTime;
        }  
    } 

}
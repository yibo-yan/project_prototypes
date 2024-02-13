using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    private float spawnRange = 9.0f;
    public float enemyCounter;


    void Start()
    {
        spawnEnemyWave(3);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCounter = FindObjectOfType<>()
    }
    private Vector3 randomPos(){
        float enemyPosX = Random.Range(-spawnRange, spawnRange);
        float enemyPosZ = Random.Range(-spawnRange, spawnRange);
        return new Vector3(enemyPosX, 0.5f, enemyPosZ);
    }
    private void spawnEnemyWave(int num){
        for(int i = 0; i < num; i++){
            Instantiate(enemy, randomPos(), enemy.transform.rotation);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemyControl : MonoBehaviour
{
    private GameObject player;
    public float speed = 3.0f;
    private Rigidbody enemyRD;
    // Start is called before the first frame update
    void Start()
    {
        enemyRD = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRD.AddForce(lookDirection * speed);
        if(transform.position.y < -5){
            Destroy(gameObject);
        }
    }
}

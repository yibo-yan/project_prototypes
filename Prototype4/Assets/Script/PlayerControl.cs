using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 1.0f;
    public GameObject focalPoint;
    private Rigidbody playerRD;
    public bool isPowerUp = false;
    public GameObject powerUpIndicator;
    // Start is called before the first frame update
    void Start()
    {
        focalPoint = GameObject.Find("focal point");
        playerRD = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        powerUpIndicator.gameObject.transform.position = transform.position - new Vector3(0, 0.5f, 0);
        float movingDirection = Input.GetAxis("Vertical");
        playerRD.AddForce(focalPoint.transform.forward * movingDirection * speed);
    }
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("powerUp")){
            Destroy(other.gameObject);
            powerUpIndicator.SetActive(true);
            isPowerUp = true;
            StartCoroutine(PowerUpCounteDown());
        }
    }
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Enemy") && isPowerUp == true){
            Debug.Log("The Player collide with" + collision.gameObject.name + " with power up");
            collision.rigidbody.AddForce((collision.transform.position - transform.position) * 20f, ForceMode.Impulse);
        }
    }
    IEnumerator PowerUpCounteDown(){
        yield return new WaitForSeconds(7);
        isPowerUp = false;
        powerUpIndicator.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
     gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();    
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        transform.Translate(Vector3.up * 9.0f * Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {

                //Destroy the enemy              
                gameManager.AddScore(10);
                Destroy(collision.gameObject);
                Destroy(this.gameObject);
            }
        }
    }
}


            

        

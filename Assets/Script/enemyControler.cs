using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyControler : MonoBehaviour
{
    public float speed;
    private Rigidbody2D _compRigidbody;
    public GameObject explosionPrefab;
    public gameManager2 _gameManager;
    void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector2(0, speed * -1);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "laser")
        {
            _gameManager.currentScore(15);
            Destroy(this.gameObject);
            Instantiate(explosionPrefab, transform.position, transform.rotation);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" )
        {
            
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag == "base")
        {
            Destroy(this.gameObject);
        }

    }
    public void SetGameManager(gameManager2 scoreGameManager)
    {
        _gameManager = scoreGameManager;
    }
}

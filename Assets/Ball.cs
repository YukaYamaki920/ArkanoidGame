using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 100.0f;
    public Score Score;
    void Start(){
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }
    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.name == "racket"){
            float x = hitFactor(transform.position, other.transform.position, other.collider.bounds.size.x);
            Vector2 direction = new Vector2(x, 1).normalized;
            GetComponent<Rigidbody2D>().velocity = direction * speed;
        }
        if(other.gameObject.tag == "block"){
            Destroy(other.gameObject);
            Score.AddScore();
        }
    }
    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth){
        return(ballPos.x - racketPos.x) / racketWidth;
    }
}

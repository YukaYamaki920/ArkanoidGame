using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomWall : MonoBehaviour
{
    public GameOver GameOver;
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == "ball"){
            Destroy(other.gameObject);
            GameOver.ShowGameOverMenu();
        }
    }
}

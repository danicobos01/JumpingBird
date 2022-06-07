using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class player_controller : MonoBehaviour {
    
    public float force;
    private RigidBody2D rb;
    private Animator anim;

    private int points;
    public Text scoreText;

    void Start() {
        rb = GetComponent<RigidBody2D>();
        anim = GetComponent<Animator>();
    }

    void Update(){
        if(Input.GetMouseButtonDown(0)){
            rb.velocity = Vector2.up * force;
            anim.SetBool("Clicked", true);
        }else{
            anim.SetBool("Clicked", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "PipesSpace"){
            points++;
            scoreText.text = "Score: " + points.toString();
        }
    }
}



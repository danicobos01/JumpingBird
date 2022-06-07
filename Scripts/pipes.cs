using System.Numerics;
using Microsoft.CSharp.RuntimeBinder;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pipes : MonoBehaviour {
    
    public float speed;
    RigidBody2D rb;

    void Start(){
        rb = GetComponent<RigidBody2D>();
    }

    void Update(){
        rb.velocity = Vector2.left * speed;
    } 

    public void private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "EndPipe"){
            Destroy(gameObject); // De esta forma en cuanto la tuberia salga de la camara se elimina el objeto para no saturar cpu
        }
    }

}
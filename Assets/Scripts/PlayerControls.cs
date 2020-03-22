using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    //bool inAction = false;
    float maxSpeed = 4.0f;    
    Rigidbody playerBody;
    void Start(){
        playerBody = gameObject.GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        if(Input.GetKeyDown("space")){
            //Debug.Log("JUMP");
            playerBody.AddForce(transform.forward * 100.0f);
            playerBody.AddForce(transform.up * 150.0f);
            while(transform.position.z > 0){
                Debug.Log("In air!");
            }
        }
        if(Input.GetKey("w") && playerBody.velocity.magnitude < maxSpeed){
            transform.position = transform.position + new Vector3(0, 0, maxSpeed * Time.deltaTime);
        }
    
        if(Input.GetKey("s") && playerBody.velocity.magnitude < maxSpeed){
            transform.position = transform.position + new Vector3(0, 0, -(maxSpeed * Time.deltaTime));
        }
        
        if(Input.GetKey("a") && playerBody.velocity.magnitude < maxSpeed){
            transform.position = transform.position + new Vector3(-(maxSpeed * Time.deltaTime), 0, 0);
        }
        
        if(Input.GetKey("d") && playerBody.velocity.magnitude < maxSpeed){
            transform.position = transform.position + new Vector3(maxSpeed * Time.deltaTime, 0, 0);
        }
    
    }
        
            //Player controls using velocity based movement
/*
        if(Input.GetKey("w") && playerBody.velocity.magnitude < maxSpeed){
            playerBody.velocity = new Vector3(playerBody.velocity.x, playerBody.velocity.y, playerBody.velocity.z + 0.25f);
            Debug.Log("Velocity: " + playerBody.velocity.x + ", " + playerBody.velocity.y + ", " + playerBody.velocity.z);
        } else if(playerBody.velocity.magnitude > maxSpeed){
            playerBody.velocity = Vector3.ClampMagnitude(playerBody.velocity, maxSpeed);
        }
    
        if(Input.GetKey("s") && playerBody.velocity.magnitude < maxSpeed){
            playerBody.velocity = new Vector3(playerBody.velocity.x, playerBody.velocity.y, playerBody.velocity.z - 0.25f);
            Debug.Log("Velocity: " + playerBody.velocity.x + ", " + playerBody.velocity.y + ", " + playerBody.velocity.z);
        } else if(playerBody.velocity.magnitude > maxSpeed){
            playerBody.velocity = Vector3.ClampMagnitude(playerBody.velocity, maxSpeed);
        }
        
        if(Input.GetKey("a") && playerBody.velocity.magnitude < maxSpeed){
            playerBody.velocity = new Vector3(playerBody.velocity.x - 0.25f, playerBody.velocity.y, playerBody.velocity.z);
            Debug.Log("Velocity: " + playerBody.velocity.x + ", " + playerBody.velocity.y + ", " + playerBody.velocity.z);
        } else if(playerBody.velocity.magnitude > maxSpeed){
            playerBody.velocity = Vector3.ClampMagnitude(playerBody.velocity, maxSpeed);
        }
        
        if(Input.GetKey("d") && playerBody.velocity.magnitude < maxSpeed){
            playerBody.velocity = new Vector3(playerBody.velocity.x + 0.25f, playerBody.velocity.y, playerBody.velocity.z);
            Debug.Log("Velocity: " + playerBody.velocity.x + ", " + playerBody.velocity.y + ", " + playerBody.velocity.z);
        } else if(playerBody.velocity.magnitude > maxSpeed){
            playerBody.velocity = Vector3.ClampMagnitude(playerBody.velocity, maxSpeed);
        }
    }
    */
    
}

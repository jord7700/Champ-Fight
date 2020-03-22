using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckHit : MonoBehaviour
{
    public Material hitMaterial;
    Ray bodyRay;                // The ray that is cast from the camera to the mouse position
    RaycastHit rayHit;    // The object that the ray hits
    Vector3 fwd;
    float maxDistance = 1.5f;

    void Update () 
    {
        fwd = gameObject.transform.TransformDirection(Vector3.forward);
        Debug.DrawRay(gameObject.transform.position, fwd * maxDistance, Color.green);
        // Cast a ray from the playerBody to the mouse cursor
        //bodyRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        // If the ray strikes an object...
        if (Physics.Raycast(transform.position, fwd, out rayHit, maxDistance) && Input.GetMouseButtonDown(0)) 
        {
            // ...and if that object is the ground...
            if(rayHit.transform.tag=="Enemy")
            {
                Debug.Log("Enemy Hit!");
                rayHit.transform.gameObject.GetComponent<MeshRenderer>().material = hitMaterial;
            }
        }
    }
}

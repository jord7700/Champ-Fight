using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    GameObject camera;
    GameObject playerBody;
    // Start is called before the first frame update
    void Start()
    {
        camera = gameObject.transform.GetChild(0).gameObject;
        playerBody = gameObject.transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        camera.transform.position = new Vector3(playerBody.transform.position.x, camera.transform.position.y, camera.transform.position.z);
    }
}

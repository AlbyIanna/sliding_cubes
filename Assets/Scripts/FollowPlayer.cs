using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    public Transform playerTransform;
    public Vector3 offset = new Vector3(0, 1, -5);
    
	void Update () {
        transform.position = playerTransform.position + offset;
	}
}

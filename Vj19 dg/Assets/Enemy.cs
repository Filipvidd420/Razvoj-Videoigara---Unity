using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public float speed;
    private void Start() {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    private void Update() {
        transform.position=Vector3.MoveTowards(transform.position,player.position,speed*Time.deltaTime);
    }
}

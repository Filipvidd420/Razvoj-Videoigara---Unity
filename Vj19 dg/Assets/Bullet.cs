using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
        private void OnTriggerEnter2D(Collider2D a)
    {
        if(a.gameObject.tag == "Enemy")
        {
            Destroy(a.gameObject);
            Destroy(gameObject);
        }
    }
    private void Update() {
        transform.Translate(1*Time.deltaTime,0,0);
    }
}

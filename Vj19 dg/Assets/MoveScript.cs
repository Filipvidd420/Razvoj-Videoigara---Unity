using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag=="Enemy")
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public float speed;
    float moveVertical;
    public int currentSceneNumber;
    //
    float moveHorizontal;
    public Rigidbody2D rb;
    private void Update() {
        moveHorizontal = Input.GetAxisRaw ("Horizontal");
        moveVertical = Input.GetAxisRaw ("Vertical");
    }
    private void FixedUpdate()
{  
   rb.velocity = new Vector2(moveHorizontal * speed, moveVertical * speed);
}
}

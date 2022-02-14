using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D bc;
    public Animator anim;
    public float x,y;
    public float moveSpeed;
    private bool isMoving,isFinish;
    private Vector3 moveDir;
    public GameObject gameManager, finishTab;

    private void start()
    {
        bc = GetComponent<BoxCollider2D>();
    }
    private void FixedUpdate()
    {
        if(!isFinish){
            x = Input.GetAxisRaw("Horizontal");
            y = Input.GetAxisRaw("Vertical");

            moveDir = new Vector3(x,y,0);

            transform.Translate(moveDir * moveSpeed * Time.deltaTime);
        }else
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            if(Input.GetKeyDown(KeyCode.Q))
            {
                SceneManager.LoadScene(0);

            }
        }

    }


    private void Update()
    {

        if(x != 0 || y!=0)
        {
            anim.SetFloat("X",x);
            anim.SetFloat("Y",y);
            if(!isMoving){
                isMoving=true;
                anim.SetBool("isMoving", isMoving);
            }
        }
        else
        {
            if(isMoving){
                isMoving=false;
                anim.SetBool("isMoving", isMoving);
            }    
        }


    }

    private void finish()
    {
        isFinish = true;
        anim.SetBool("isFinish", isFinish);
        Destroy(gameManager);
        finishTab.SetActive(true);

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if(other.gameObject.tag == "FinishLine")
        {
            finish();
        }   
    }



}

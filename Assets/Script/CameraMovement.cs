using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform lookAt;
    public float boundX = 0.15f;
    public float boundY = 0.05f;

    // Update is called once per frame
    private void LateUpdate()
    {
        // cek apakah kita ada di batas 
       Vector3 delta = Vector3.zero;
       float deltaX = lookAt.position.x - transform.position.x;
       float deltaY = lookAt.position.y - transform.position.y;

        // cek apakah kita ada di batas X 
       if(deltaX > boundX || deltaX < -boundX){
           if(transform.position.x < lookAt.position.x){
               delta.x = deltaX - boundX;
           }else{
               delta.x = deltaX + boundX;
           }
       }
       // cek apakah kita ada di batas X 
       if(deltaY > boundY || deltaY < -boundY){
           if(transform.position.y < lookAt.position.y){
               delta.y = deltaY - boundY;
           }else{
               delta.y = deltaY + boundY;
           }
       }  

       transform.position += new Vector3 (delta.x, delta.y, 0);



    }
}

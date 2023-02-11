using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed=11f;
    [SerializeField] private Gameinput gameInput;



    private void Update()
    {
        
        Vector2 inputVector=gameInput.GetMovementVectorNormalized();
        Vector3 moveDir = new Vector3(inputVector.x,0f,inputVector.y);

        float playerSize=0.3f;
        bool canMove=!Physics.Raycast(transform.position,moveDir,playerSize);
        if(canMove){

            transform.position += moveDir*moveSpeed* Time.deltaTime;
        
        }
    }
    
    
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ManegerPlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    private float Speed, JumpForce;

    [SerializeField]
    private bool chao, _jump, _doubleJump;
    public Transform _transCheckChao;   
    


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
       
    }
    private void Update()
    {        
        chao = Physics2D.Linecast(transform.position, _transCheckChao.transform.position, 1 << LayerMask.NameToLayer("chao"));        
        
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);

            managerGame.iniciou = true;

            if (t.phase == TouchPhase.Began)
            {
               if(chao && !_jump)
               {
                    oneJump();
                    _doubleJump = true;
               }               
               if(!chao && _doubleJump)
               {
                    twoJump();
               }
            }
        }
        if (chao && _jump)
        {
            _jump = false;
        }
    }  
    void oneJump()
    {
        rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
        _jump = true;
    }
    void twoJump()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0f);
        rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
        _doubleJump = false;
    }
    
}
    


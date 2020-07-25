using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    

    public int whichOne;

    public bool switcher = false;

    [SerializeField]
    private float speed = 3.0f;
    [SerializeField]
    private float jumpForce = 10.0f;

    private bool isGrounded = false;

    new private Rigidbody2D rigidbody;
    private Animator animator;
    private SpriteRenderer sprite;

   

    private CharState State
    {
        get { return (CharState)animator.GetInteger("State"); }
        set { animator.SetInteger("State", (int)value); }
    }

    private void Awake()
    {
      
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        CheckGround();

      
    }

    private void Update()
    {
        if (isGrounded) State = CharState.Idle;

        if (Input.GetButton("Horizontal")) Run();
        if (isGrounded && Input.GetButtonDown("Jump")) Jump();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }

        

    }

    private void Run()
    {
        Vector3 direction = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
        sprite.flipX = direction.x < 0.0f;
        if (isGrounded) State = CharState.Run;
    }

    private void Jump() 
    {
        rigidbody.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }

    private void CheckGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.3f);
        isGrounded = colliders.Length > 1;

        if (!isGrounded) State = CharState.Jump;
    }



    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Game" && Mathf.Abs(collision.transform.position.x - transform.position.x) <= 3.3F || collision.collider.tag == "Police" && Mathf.Abs(collision.transform.position.x - transform.position.x) <= 6F)
        {
            

            Debug.Log(collision.collider.name);
            Debug.Log("Enter");
            switcher = true;

            switch (collision.collider.name)
            {
                case "FirstGame": whichOne = 1; 
                    break;
               
                case "SecondGame": whichOne = 2; 
                    break;

                case "ThirdGame": whichOne = 3; 
                    break;
               
                case "FourthGame": whichOne = 4; 
                    break;
               
                case "FifthGame": whichOne = 5; 
                    break;
                
                case "SixthGame": whichOne = 6; 
                    break;
               
                case "SeventhGame": whichOne = 7; 
                    break;
               
                case "EighthGame":  whichOne = 8; 
                    break;
               
                case "NinthGame":  whichOne = 9; 
                    break;
              
                case "TenthGame": whichOne = 10; 
                    break;
               
                case "EleventhGame": whichOne = 11;
                    break;
              
                case "TwelfthGame": whichOne = 12; 
                    break;

                case "Officer":
                    whichOne = 13;
                    break;

            }


            Debug.Log(whichOne);
            

        } 

        if (collision.gameObject.tag.Equals("Moving"))
        {
            this.transform.parent = collision.transform;

          
        }
        

    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Game" && Mathf.Abs(collision.transform.position.x - transform.position.x) >= -1F 
         || collision.collider.tag == "Police" && Mathf.Abs(collision.transform.position.x - transform.position.x) <= 6F)
        {
            Debug.Log("Exit");
            switcher = false;

            
        }
       
        if (collision.gameObject.tag.Equals("Moving"))
        {
            this.transform.parent = null;
        }

    }

    
  

}

public enum CharState
{
    Idle,
    Run,
    Jump
}

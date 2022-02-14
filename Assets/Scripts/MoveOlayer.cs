using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveOlayer : MonoBehaviour
{
    public Vector2 jumpHeight;
    [SerializeField] private bool grounded;
    public float moveSpeed;
    private Rigidbody2D _rigidbody;
    public int fullHealth;
    [SerializeField]private Animator animator;
    public Transform spawnBullet;
    public GameObject bullet;
    public GameObject deathScreen;
    public Enemy enemy;
    public int kills;
    [SerializeField] private GameObject inputField;


    // Start is called before the first frame update
    void Start()
    {
        fullHealth = 3;
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Shot();
        Move();
        Gravity();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {

        if (collision.transform.tag == "Ground")
        {
            grounded = true;
            animator.SetBool("Jump", false);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            grounded = false;
        }
    }

    private void Move()
    {        
        _rigidbody.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, _rigidbody.velocity.y);
        animator.SetFloat("Run", Mathf.Abs(Input.GetAxis("Horizontal")));
    }

    public void TakeDamage(int damage)
    {
        fullHealth = fullHealth - damage;
       
        if (fullHealth <= 0)
        {
            Time.timeScale = 0f;
            deathScreen.SetActive(true);

            if (kills > PlayerPrefs.GetInt("Player1Score"))
            {
                deathScreen.GetComponent<SaveResults>().finishKills = kills;
                inputField.SetActive(true);
            }            
        }
    }

    public void Shot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetBool("Shot", true);
            Instantiate(bullet, spawnBullet.position, Quaternion.identity);
        }
        else
        {
            animator.SetBool("Shot", false);
        }
    }

    public void Gravity()
    {
        //if (Input.GetKey(KeyCode.Space))
        //{
        //    if (grounded)
        //    {
        //        GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
        //        animator.SetBool("Jump", true);
        //    }
        //}

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            GetComponent<Rigidbody2D>().gravityScale *= -1;
            if (GetComponent<SpriteRenderer>().flipY == true)
            {
                GetComponent<SpriteRenderer>().flipY = false;
            }
            else
            {
                GetComponent<SpriteRenderer>().flipY = true;
            }            
        }
    }

}

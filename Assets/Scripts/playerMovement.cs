using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Animator animator;
    GameController controller;
    private AudioSource audioSource;
    [SerializeField] ParticleSystem playerSmoke;
    [SerializeField] ParticleSystem dirtParticle;
    [SerializeField] AudioClip jumpSound,crashSound;

    public float jumpForce = 2f;
    public float modifiedGravity = 4.5f;

    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity *= modifiedGravity;
        rb = GetComponent<Rigidbody>();
        animator =gameObject.GetComponent<Animator>();
        controller= GameObject.Find("GameController").GetComponent<GameController>();
        //controller = GameObject.FindAnyObjectByType<GameController>();

        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Input Space
        if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded && !controller.isGameOver)
        {
            rb.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
            controller.isGrounded =false;
            animator.SetTrigger("Jump_trig");
            audioSource.PlayOneShot(jumpSound, 1.0f);
            dirtParticle.Stop();
        }
    }

    private void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.CompareTag("Ground")) 
        {
            controller.isGrounded =true;
            dirtParticle.Play();

        }

         else if (collider.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Obstacle + Game Over!");
            controller.GameOver();
        }
        else if (collider.gameObject.CompareTag("Obstacle"))
        {
            controller.isGameOver =true;
            Debug.Log("Game Over!");
            animator.SetTrigger("Death_b");
            animator.SetInteger("DeathType_int", 2);
            audioSource.PlayOneShot(crashSound, 1.0f);
            playerSmoke.Play();
            dirtParticle.Stop();

        }
    }
}

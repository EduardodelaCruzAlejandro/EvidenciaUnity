using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JumpBox : MonoBehaviour
{
    public Animator animator;

    public SpriteRenderer spriteRenderer;

    public GameObject brokenParts;

    public float jumpForce = 4f;

    public int lifes = 1;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity=Vector2.up * jumpForce;
            LoseLifeAndHit();
        }
    }

    public void LoseLifeAndHit()
    {
        lifes--;
        animator.Play("Hit");
        CheckLife();
    }

    public void CheckLife()
    {
        if (lifes<=0)
        {
            brokenParts.SetActive(true);
            spriteRenderer.enabled = false;
            Invoke("DestroyBox", 0.5f);
        }
    }

    public void DestroyBox()
    {
        Destroy(gameObject);
    }





}

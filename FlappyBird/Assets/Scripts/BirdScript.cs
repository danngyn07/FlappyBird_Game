using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    public Rigidbody2D MyRigidbody;
    public float flapStrength;

    public Sprite[] sprites;
    private int spriteIndex;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        InvokeRepeating(nameof(AnimateSprite) , 0.15f , 0.15f);
    }
    private void OnEnable()
    {
        transform.position = new Vector3(0, 0, 0);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            MyRigidbody.velocity = Vector2.up * 5;
        }
        
    }

    private void AnimateSprite()
    {
        spriteIndex++;
        if (spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }
        spriteRenderer.sprite = sprites[spriteIndex];

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            FindObjectOfType<LogicScript>().GameOver();
        }
        else if(other.gameObject.tag == "Scoring" )
        {
            FindObjectOfType<LogicScript>().IncreaseScore();
        }
    }
}

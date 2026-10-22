using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput > 0)      sr.flipX = false; // Face right
        else if (horizontalInput < 0) sr.flipX = true;  // Face left

        Vector2 movement = new Vector2(horizontalInput, 0f);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}

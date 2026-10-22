using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    [SerializeField] private float activationDistance = 0.0001f;

    private Animator animator;
    private Vector3 firstPosition;

    void Start()
    {
        animator = GetComponent<Animator>();
        firstPosition = transform.position;
    }

    void Update()
    {
        float distanceThisFrame = Vector2.Distance(firstPosition, transform.position);

        if (distanceThisFrame >= activationDistance)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        firstPosition = transform.position;
    }
}

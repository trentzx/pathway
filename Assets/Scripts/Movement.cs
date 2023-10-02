
using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{

        public float speed = 8.0;

    public float speedMultiplier = 1f;

    public Vector2 initialDirection;

    public LayerMask obstaclelayer;

    public new Rigidbody2D rigidbody { get:private set; }

    public Vector2 direction {  get; private set; }

    public Vector2 nextDirection { get; private set; }

    public Vector3 startingPosition { get; private set; }

    private void Awake()
    {
    this.rigidbody = GetComponent<Rigidbody2D>();
    this.startingPosition = transform.position;
    }

    private void Start()
    {

    }

    public void ResetState()
    {
       
    }

}

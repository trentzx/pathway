
using UnityEngine;

<<<<<<< Updated upstream
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
=======
[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{

    public float speed = 8.0f;

    public float speedMultiplier = 1.0f;

    public Vector2 initialDirection;
    public LayerMask obstacleLayer;
    public new Rigidbody2D rigidbody { get; private set; }
    public Vector2 direction { get; private set; }
    public Vector2 nextDirection { get; private set; }
    public Vector3 startingPosition {  get; private set; }

    private void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
        this.startingPosition = this.transform.position;
>>>>>>> Stashed changes
    }

    private void Start()
    {
<<<<<<< Updated upstream

    }

    public void ResetState()
    {
       
=======
        ResetState();  
    }
    public void ResetState()
    {
        this.speedMultiplier = 1.0f;
        this.direction = this.initialDirection;
        this.nextDirection = Vector2.zero;
        this.transform.position = this.startingPosition;
        this.rigidbody.isKinematic = false;
        this.enabled = true;
    }


    private void FixedUpdate()
    {
        Vector2 position = this.rigidbody.position;
        Vector2 translation = this.direction * this.speed * this.speedMultiplier * Time.fixedDeltaTime;
        this.rigidbody.MovePosition(position + translation);
    }

    public void SetDirection(Vector2 direction, bool)
    {
        if(!Occupied(direction))
        {
            this.direction = direction;
            this.nextDirection = Vector2.zero;
        }
        else
        {
            this.nextDirection = direction;
        }
    }

    public bool Occupied(Vector2 direction)
    {
        RaycastHit2D hit = Physics2D.BoxCast(this.transform.position, Vector2.one * 0.75f, 0.0f, direction, 1.5f, this.obstacleLayer);
        return hit.collider != null;
>>>>>>> Stashed changes
    }

}

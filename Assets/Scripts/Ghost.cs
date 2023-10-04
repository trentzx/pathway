using UnityEngine;

public class Ghost : MonoBehaviour
{
    public Movement movement { get; private set; }
    public GhostHome home { get; private set; }
    public GhostScatter scatter { get; private set; }
    public GhostChase chase { get; private set; }
    public GhostFrightened frightened { get; private set; }
    public Ghostbehaviour initialBehaviour;
    public Transform target;
    public int points = 200;

    private void Awake()
    {
        this.movement = GetComponent<movement>();
        this.home = GetComponent<GhostHome>();
        this.scatter = GetComponent<GhostScatter>();
        this.chase = GetComponent<GhostChase>();
        this.hfrightened = GetComponent<GhostFrightened>();
    }

    private void Start()
    {
        ResetState();
    }
    public void ResetState()
    {

    }
}

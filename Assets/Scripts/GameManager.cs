using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ghost[] ghosts;

    // Assuming Pacman is in the same namespace as GameManager
    public Pacman pacman;

    public Transform pellets;

    public int score { get; private set; }
    public int lives { get; private set; }

    private void Start()
    {
        NewGame();
    }

    private void NewGame()
    {
        SetScore(0);
        SetLives(3);
        NewRound();
    }

    private void Update()
    {
        if (this.lives <= 0 && Input.anyKeyDown)
        {
            NewGame();
        }
    }

    private void NewRound()
    {
        foreach (Transform pellet in pellets)
        {
            pellet.gameObject.SetActive(true);
        }

        ResetState();
    }

    private void ResetState()
    {
        foreach (Ghost ghost in ghosts)
        {
            ghost.gameObject.SetActive(true);
        }

        pacman.gameObject.SetActive(true); // Assuming pacman is a public field of type Pacman
    }

    private void GameOver()
    {
        foreach (Ghost ghost in ghosts)
        {
            ghost.gameObject.SetActive(false);
        }

        pacman.gameObject.SetActive(false);
    }

    private void SetScore(int score)
    {
        this.score = score;
    }

    private void SetLives(int lives)
    {
        this.lives = lives;
    }

    public void GhostEaten(Ghost ghost)
    {
        SetScore(this.score + ghost.points);
    }

    public void PacmanEaten() // Fix the method name to match the capitalization
    {
        pacman.gameObject.SetActive(false);

        SetLives(lives - 1);

        if (lives > 0)
        {
            Invoke(nameof(ResetState), 3.0f);
        }
        else
        {
            GameOver();
        }
    }
}

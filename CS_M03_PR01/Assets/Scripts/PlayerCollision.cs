using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    private GameManager gameManager;

    private Material playerColor;
    private Color deathColor = new Color(1f, .5f, 1f, .5f);

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerColor = GetComponent<Renderer>().material;
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle")
        {
            playerColor.SetColor("_Color", deathColor);
            movement.enabled = false;
            gameManager.EndGame();
        }
    }
}

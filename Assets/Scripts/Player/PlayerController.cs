using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public SpriteRenderer playerSprite;

    private Camera mainCamera;
    private float playerSpriteHalfWidth;
    private float rightScreenEdge;
    private float leftScreenEdge;

    // Start is called before the first frame update
    void Start()
    {
        // Initialise mainCamera variable with the game's current main camera
        mainCamera = Camera.main;

        // Find the point in game world where the right screen edge touches
        Vector2 screenTopRightCorner = new Vector2(Screen.width, Screen.height);
        Vector2 topRightCornerInWorldSpace = mainCamera.ScreenToWorldPoint(screenTopRightCorner);
        rightScreenEdge = topRightCornerInWorldSpace.x;

        // Find the point in game world where the left screen edge touches
        Vector2 screenBottomLeftCorner = new Vector2(0f, 0f);
        Vector2 bottomLeftCornerInWorldSpace = mainCamera.ScreenToWorldPoint(screenBottomLeftCorner);
        leftScreenEdge = bottomLeftCornerInWorldSpace.x;

        // Calculate the value of the player sprite's half-width
        playerSpriteHalfWidth = playerSprite.bounds.size.x * 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

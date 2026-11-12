using UnityEngine;

public class playermovement : MonoBehaviour
{
    float horInput;
    float verInput;

    public float playerMovementSpeed;
    private float movementMultiplier = 1;

    public bool isSpeeding;

    Transform playerTransform;
    Vector3 playerPosition;

    private void start()
    {
        playerTransform = this.gameObject.getComponent<Transform>();
    }

    private void Update()
    {
        horInput = Input.GetAxis("Horizontal");
        verInput = Input.GetAxis("Vertical");

        if(horInput != 0)
        {
            playerPosition.x += horInput;
        }
        
        if(verInput != 0)
        {
            playerPosition.z += verInput;
        }
       //sprint
       if (isSpeeding)
        {
            movementMultiplier = 2;
        }
        else
        {
            movementMultiplier = 1;
        }

        playerPosition = playerTransform.position;

       
        playerPosition.x += horInput * playerMovementSpeed * Time.deltaTime * movementMultiplier;
        playerPosition.z += verInput * playerMovementSpeed * Time.deltaTime * movementMultiplier;

        playerTransform.position = playerPosition;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

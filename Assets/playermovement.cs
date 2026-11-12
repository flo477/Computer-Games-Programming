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
       if (isSpeeding) // key addition
        {
            movementMultiplier = 3;
        }
        else if(Input.GetKey(KeyCode.LeftShift)) 
        {
            movementMultiplier = 2;
        }
        // sneak
        else if(Input.GetKey(KeyCode.LeftControl)) 
        {
            movementMultiplier = 0.5f;
        }
        // default
        else
        {
            movementMultiplier = 1;
        }

        playerTransform.Translate(playerPosition.normalized * playerMovementSpeed * 
        movementMultiplier * Time.deltaTime, Space.World);

        playerPosition = Vector3.zero;

        Vector mouseDirection = Input.mousePosition - camera.main.WorldToScreenPoint(this.transform.position);

    
        float angle = Mathf.Atan2(mouseDirection.y, mouseDirection.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.Euler(0f, angle,0f);

        playerPosition.x += horInput * playerMovementSpeed * Time.deltaTime * movementMultiplier;
        playerPosition.z += verInput * playerMovementSpeed * Time.deltaTime * movementMultiplier;

        playerTransform.position = playerPosition;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
}

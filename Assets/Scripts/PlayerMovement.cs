using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    //generate pointers
    
    Vector3 place;
    Transform cameraPos;
    

    void Awake()
    {
        cameraPos = GameObject.Find("Main Camera").transform;
    }


    void Update()
    {
        
        //pointers to transform, position and rotation
        
        place = transform.position;

        if (Input.GetKey(KeyCode.A))
        {
            place.x -= PlayerStat.playerSpeed;
            Rotate(180);

        }
        if (Input.GetKey(KeyCode.D))
        {

            place.x += PlayerStat.playerSpeed;
            Rotate(0);
            
        }
        if (Input.GetKeyDown(KeyCode.Space) && GetComponent<Rigidbody2D>().IsTouchingLayers() )
        {
            place.y += 3f;
            
            
          
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            PlayerStat.playerSpeed *= 2;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            PlayerStat.playerSpeed = PlayerStat.initplayerSpeed;
        }
        
        transform.position = place;
        place.z = -10;
        place.y += 2;
        cameraPos.position = place;
        
        
    }

    //Rotating
    void Rotate(float angle)
    {
        Quaternion theRotation = transform.localRotation;
        theRotation.y = angle;
        theRotation.x = 0;
        transform.localRotation = theRotation;




    }
    
}

using UnityEngine;

public class pmove : MonoBehaviour {

   public Rigidbody rb;

    public float forwardMovement = 2000f;
    public float sidewaysMovement = 500f;
    // Update is called once per frame
    void FixedUpdate()
    {
       rb.AddForce(0, 0, forwardMovement * Time.deltaTime); 

       if ( Input.GetKey("d") )
       {
           rb.AddForce(sidewaysMovement * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
       }
    
   if ( Input.GetKey("a") )
       {
           rb.AddForce(-sidewaysMovement * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
       }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManagement>().EndGame();
        }
    }
}   
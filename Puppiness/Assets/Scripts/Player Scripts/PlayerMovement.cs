using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /*The Code Snippet (1.Player Movement) below has been adapted from
     * https://www.youtube.com/watch?v=1o-Gawy3D48
     * https://docs.unity3d.com/ScriptReference/CharacterController.Move.html
     */
    private Vector3 move_Direction;

    public float speed = 5f;
    private float vertical_Velocity;

    /*void Awake()
    {
        character_Controller = GetComponent<CharacterController>();
    }*/

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Oculus_CrossPlatform_PrimaryThumbstick"))
        {
          MovePlayer();  
        }
    }

    //get player to move
    void MovePlayer()
    {
        move_Direction = new Vector3(Input.GetAxis(Axis.HORIZONTAL), 0f, Input.GetAxis(Axis.VERTICAL));

        move_Direction = transform.TransformDirection(move_Direction);
        move_Direction *= speed * Time.deltaTime;

        //character_Controller.Move(move_Direction);
    }

    //End Code Snipper (1. Player Movement)
}

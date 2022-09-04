using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPad : Paddle
{
    //Direction of Player Movements in 2D space (aka:x,y)
    private Vector2 _direction;

    //called every frame
    private void Update()
    {
        //check if user pressed the key W or Up
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            //make the direction point to up
            _direction = Vector2.up;
        }
        //check if user pressed the key S or Down
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            //make the direction point to Down
            _direction = Vector2.down;
        }
        //User Waiting And not Doing anything
        else
        {
            //make the direction zero
            _direction = Vector2.zero;
        }
    }
    //moving based On direction
    //Fixed Update Is For Physics
    public void FixedUpdate()
    {
        //if the direction not zero, means the user is making some movement
        if (_direction.sqrMagnitude != 0)
        {
            //add force to move the object based on direction and speed given
            _rp2d.AddForce(_direction * this._speed);
        }
    }
}

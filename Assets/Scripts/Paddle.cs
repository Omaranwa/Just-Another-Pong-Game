using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
this script is for storing all values that CpuPaddle and userPaddle
is using, speed, a reference to rigid body component 
- also its assigning the RigidBody Component to the value _rp2d on Awake() method
*/
public class Paddle : MonoBehaviour
{
    //Player Paddle Speed
    public float _speed = 50.0f;
    //Store RigidBody Component
    protected Rigidbody2D _rp2d;
    //Called Once in the game start
    public void Awake()
    {
        //assign Rigidbody2D Component To _rp2d
        _rp2d = GetComponent<Rigidbody2D>();
    }
}

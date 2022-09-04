using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float _speed = 150.0f;
    //reference to store rigidbody component
    private Rigidbody2D _rig2d;
    //Called Once the Game start
    private void Awake() 
    {
        _rig2d = GetComponent<Rigidbody2D>();
    }
    //Called on the first frame
    private void Start() 
    {
        AddStartingForce();
    }

    //Force that ball start with
    private void AddStartingForce()
    {

        //Random X float value Bettwen -1.0 and 1.0
        float x = Random.value < 0.5f ? -1.0f : 1.0f;

        //Random y float value Bettwen -1.0 and 1.0
        float y = Random.value < 0.5f ? Random.Range(minInclusive: -1.0f, maxInclusive: -0.5f) :
                                        Random.Range(minInclusive: 0.5f, maxInclusive: 1.0f);    
        
        //Direction of first movement
        Vector2 _direction = new Vector2(x: x, y: y);

        //add force to ball = make it move\
        _rig2d.AddForce(force: _direction * this._speed);
    }
}
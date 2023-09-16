using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEMO : MonoBehaviour
{
    public GameObject tank;
    private Tank _tankComp;
    private string _movementState;
    private string _shootXState;
    private string _shootYState;
    private float _shootDirectionChangingAmount;

    // Start is called before the first frame update
    void Awake()
    {
        _tankComp = tank.GetComponent<Tank>();
        _shootDirectionChangingAmount = 3;
    }

    // Update is called once per frame
    void Update()
    {
        // Movement
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _movementState = "Move";
            _tankComp.moveSpeed = Mathf.Abs(_tankComp.moveSpeed);
        }else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            _movementState = "Stop";
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _movementState = "Move";
            _tankComp.moveSpeed = -Mathf.Abs(_tankComp.moveSpeed);
        }else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            _movementState = "Stop";
        }
        if (_movementState == "Move")
        {
            _tankComp.Move();
        }

        // Shoot
        if (Input.GetKeyDown(KeyCode.W))
        {
            _shootYState = "Increase";
        }else if (Input.GetKeyUp(KeyCode.W))
        {
            _shootYState = "NONE";
        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            _shootYState = "Decrease";
        }else if (Input.GetKeyUp(KeyCode.S))
        {
            _shootYState = "NONE";
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            _shootXState = "Increase";
        }else if (Input.GetKeyUp(KeyCode.D))
        {
            _shootXState = "NONE";
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            _shootXState = "Decrease";
        }else if (Input.GetKeyUp(KeyCode.A))
        {
            _shootXState = "NONE";
        }
        
        if (_shootYState == "Increase")
        {
            _tankComp.SetShootY(_shootDirectionChangingAmount);
        }
        if (_shootYState == "Decrease")
        {
            _tankComp.SetShootY(-_shootDirectionChangingAmount);
        }
        if (_shootXState == "Increase")
        {
            _tankComp.SetShootX(_shootDirectionChangingAmount);
        }
        if (_shootXState == "Decrease")
        {
            _tankComp.SetShootX(-_shootDirectionChangingAmount);
        }
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _tankComp.Shoot();
        }
        _tankComp.TurretLookAt();

    }
}

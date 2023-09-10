using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEMO : MonoBehaviour
{
    public GameObject tank;
    private Tank _tankComp;
    private string _state;
    // Start is called before the first frame update
    void Awake()
    {
        _tankComp = tank.GetComponent<Tank>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _state = "Move";
            _tankComp.moveSpeed = Mathf.Abs(_tankComp.moveSpeed);
        }else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            _state = "Stop";
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _state = "Move";
            _tankComp.moveSpeed = -Mathf.Abs(_tankComp.moveSpeed);
        }else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            _state = "Stop";
        }
        if (_state == "Move")
        {
            _tankComp.Move();
        }

    }
}

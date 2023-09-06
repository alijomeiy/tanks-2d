using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.AdaptivePerformance.Editor;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public int TankSpeed;
    public int TargetX;
    public int TargetY;
    
    // The negative TankSpeed means you are going to left.
    
    public int Health;
    public List<GameObject> Bullets;
    public Sprite TankSprite;
    private GameObject _pipe;
    [SerializeField] private Vector3 _velocity;
    

    public void GoForwardOrBackward()
    {
        _velocity = Vector3.right * TankSpeed;
        transform.position += _velocity;
        _pipe.transform.position += _velocity;
    }
    
    public void SetPipeRotation()
    {
        _pipe.transform.rotation = Quaternion.LookRotation(new Vector3(TargetX, TargetY, 0) - _pipe.transform.position);
    }

    public void ChangeHealth(int force)
    {
        Health -= force;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public PlayerJump _playerJump;

    public Animator Animator
    {
        get { return _animator; } 
    }


    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        _playerJump.Executed += PlayerJump_Executed;
        _playerJump.Grounded += PlayerJump_Grounded;
    }

    private void OnDisable()
    {
        _playerJump.Executed -= PlayerJump_Executed;
        _playerJump.Grounded -= PlayerJump_Grounded;
    }

    private void PlayerJump_Executed()
    {


        _animator.SetBool("jumping", true);
    }

    private void PlayerJump_Grounded()
    {

        _animator.SetBool("jumping", false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    [SerializeField]
    private Animator _animator;
}

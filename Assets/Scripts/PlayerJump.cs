using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public event Action Executed;
    public event Action Grounded;

    public bool Allowed
    {
        get { return _allowed; }
        set { _allowed = value; }
    }

    public IEnumerator Execute()
    {
       // _active = true;
        _allowed = false;

        float currentTime = 0;
        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            _physics.Velocity = new Vector2(_physics.Velocity.x, speed);
            yield return null;
        }

      //  _active = false;
    }

    protected void Awake()
    {
        _physics = GetComponent<PlayerPhysics>();
        _inputManager = FindObjectOfType<InputManager>();
    }

    protected void OnEnable()
    {
        _inputManager.JumpButtonPressed += InputManager_JumpButtonPressed;
        _physics.Grounded += Physics_Grounded;
    }

    protected void OnDisable()
    {
        _inputManager.JumpButtonPressed -= InputManager_JumpButtonPressed;
        _physics.Grounded -= Physics_Grounded;
    }

    private void InputManager_JumpButtonPressed(object sender, JumpButtonPressedArgs e)
    {
        if (_allowed)
        {
            StartCoroutine(Execute());
            OnExecute();
        }
    }

    private void OnExecute()
    {
        Executed?.Invoke();
    }

    private void OnGronded()
    {
        Grounded?.Invoke();
    }


    private void Physics_Grounded()
    {
        _allowed = true;
        OnGronded();        
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    protected PlayerPhysics _physics;

    [SerializeField]
    private InputManager _inputManager;

    [SerializeField]
    private float duration = 2.5f;

    [SerializeField]
    private float speed = 7;

    [SerializeField]
    private bool _allowed = false; 
}

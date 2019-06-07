using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpArgs : EventArgs
{

}

public class PlayerManager : MonoBehaviour
{
    public InputManager inputManager;
    public event EventHandler<JumpArgs> JumpRequest;

    private void OnEnable()
    {
        inputManager.JumpButtonPressed += InputManager_JumpButtonPressed;
    }

    private void OnDisable()
    {
        inputManager.JumpButtonPressed -= InputManager_JumpButtonPressed;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void InputManager_JumpButtonPressed(object sender, JumpButtonPressedArgs e)
    {
        OnJumpRequest(new JumpArgs());
    }

    protected void OnJumpRequest(JumpArgs args)
    {
        JumpRequest?.Invoke(this, args);
    }
}
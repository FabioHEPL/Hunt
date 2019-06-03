using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpButtonPressedArgs : EventArgs
{

}

public class ThrowButtonPressedArgs : EventArgs
{

}

public class InputManager : MonoBehaviour
{
    public event EventHandler<JumpButtonPressedArgs> JumpButtonPressed;
    public event EventHandler<ThrowButtonPressedArgs> ThrowButtonPressed;

    private void OnJumpButtonPressed(JumpButtonPressedArgs args)
    {
        JumpButtonPressed?.Invoke(this, args);
    }

    private void OnThrowButtonPressed(ThrowButtonPressedArgs args)
    {
        ThrowButtonPressed?.Invoke(this, args);
    }

    public void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            OnJumpButtonPressed(new JumpButtonPressedArgs());
        }

        if (Input.GetButtonDown("Throw"))
        {
            OnThrowButtonPressed(new ThrowButtonPressedArgs());
        }
    }
}

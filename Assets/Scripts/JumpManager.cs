using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpManager : MonoBehaviour
{
    public PlayerManager playerManager;
    public bool jumping = false;
    public Vector2 direction = Vector2.up;
    public float duration = 5f;
    public float maxHeight = 10f;

    private void OnEnable()
    {
        playerManager.Jump += PlayerManager_Jump;
    }

    private void OnDisable()
    {
        playerManager.Jump -= PlayerManager_Jump;
    }

    private void PlayerManager_Jump(object sender, JumpArgs e)
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public IEnumerator Jump()
    {
        while (jumping)
        {
            

            yield return null;
        }
    }
}

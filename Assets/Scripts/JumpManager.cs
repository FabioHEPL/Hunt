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
    public float speed = 0.1f;

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
        if (!jumping)
        {
            StartCoroutine(Jump());
        }
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
        jumping = true;

        float currentTime = 0;

        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            transform.position += (Vector3)(Vector2.up * speed);
            yield return null;
        }

        jumping = false;
    }
}

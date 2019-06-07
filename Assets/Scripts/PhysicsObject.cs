using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PhysicsObject : MonoBehaviour
{
    // ------------------------------------------------------------------------------------
    // @ PUBLIC
    // ------------------------------------------------------------------------------------
    public float GravityScale
    {
        get { return gravityScale; }
        set { gravityScale = value; }
    }

    public Vector2 Velocity
    {
        get { return _velocity; }
        set { _velocity = value; }
    }


    public float MinimumDistance
    {
        get { return minimumDistance = 0.01f; }
        set { minimumDistance = value; }
    }


    //private Rigidbody2D rigidbody;
    public Rigidbody2D Rigidbody2D { get; set; }

    // ------------------------------------------------------------------------------------
    // @ PRIVATE
    // ------------------------------------------------------------------------------------
    private void Awake()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {

    }

    private void FixedUpdate()
    {
        Vector2 velocity = _velocity * gravityScale * Physics2D.gravity * Time.deltaTime;

        // This is the direction of the player
        Vector2 direction = velocity.normalized;
        // This is the distance the player is going to cover
        float distance = velocity.magnitude;
        
        
        // DEBUG
     

        // Check for collisions
        if (distance > minimumDistance)
        {
            int count = Rigidbody2D.Cast(direction, raycastHitBuffer, distance);
            Debug.DrawRay(transform.position, direction, Color.green, distance);

            for (int i = 0; i < count; i++)
            {
                Vector2 hitNormal = raycastHitBuffer[i].normal;

                float dotProduct = Vector2.Dot(velocity, hitNormal);
                Debug.Log(String.Format("dot product norm : {0}\n dot product NOT norm : {1}", Vector2.Dot(direction, hitNormal), Vector2.Dot(velocity, hitNormal)));

                // check if we hit a perpendicular or semi-perpendicular surface
                if (dotProduct < 0)
                {
                    this._velocity = velocity - dotProduct * hitNormal;
                }

                float modifiedDistance = raycastHitBuffer[i].distance - 0.5f;
                distance = modifiedDistance < distance ? modifiedDistance : distance;
            }
        }

        Rigidbody2D.position = Rigidbody2D.position + direction * distance;



        //_velocity += gravityScale * Physics2D.gravity * Time.deltaTime;

        //Vector2 move = Vector2.up * _velocity.y;


        //Debug.Log(_velocity);
        //Compute(velocity);
    }

    private void Compute(Vector2 velocity)
    {
        Vector2 direction = velocity.normalized;
        float distance = velocity.magnitude;

        Debug.DrawRay(transform.position, direction, Color.green, 0.02f);

        if (distance > minimumDistance)
        {
            int count = Rigidbody2D.Cast(direction, raycastHitBuffer, 0.5f);
            for (int i = 0; i < count; i++)
            {
                Vector2 hitNormal = raycastHitBuffer[i].normal;

                float dotProduct = Vector2.Dot(velocity, hitNormal);
                Debug.Log(String.Format("dot product norm : {0}\n dot product NOT norm : {1}", Vector2.Dot(direction, hitNormal), Vector2.Dot(velocity, hitNormal)));

                // check if we hit a perpendicular or semi-perpendicular surface
                if (dotProduct < 0)
                {
                    this._velocity = velocity - dotProduct * hitNormal;
                }

                float modifiedDistance = raycastHitBuffer[i].distance - 0.5f;
                distance = modifiedDistance < distance ? modifiedDistance : distance;
            }
        }

        Rigidbody2D.position = Rigidbody2D.position + direction * distance;
    }

    private void ArrayToList<T>(T[] array, int length)
    {
        List<T> list = new List<T>(length);

        for (int i = 0; i < length; i++)
        {
            list[i] = array[i];
        }
    }


    private RaycastHit2D[] raycastHitBuffer = new RaycastHit2D[16];
    //private List<RaycastHit2D> hit2DList = new List

    [SerializeField]
    private float minimumDistance;

    [SerializeField]
    private float gravityScale;

    [SerializeField]
    private Vector2 _velocity;
}

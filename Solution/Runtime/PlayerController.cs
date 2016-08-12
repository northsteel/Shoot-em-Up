using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Player controller and behavior
/// </summary>
public class PlayerController : MonoBehaviour
{
    #region FIELDS

    /// <summary>
    /// The speed of the ship
    /// </summary>
    [SerializeField]
    private Vector2 force = new Vector2(50f, 50f);

    /// <summary>
    /// Reference to Rigidbody2D component
    /// </summary>
    private Rigidbody2D rb;

    /// <summary>
    /// Stores the movement
    /// </summary>
    private Vector2 movement;

    #endregion

    #region PROPERTIES



    #endregion

    #region METHODS

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {

    }

    private void Update()
    {
        // Retrieve axis information
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        // Movement per direction
        movement = new Vector2(Time.deltaTime * force.x * inputX, Time.deltaTime * force.y * inputY);
    }

    private void FixedUpdate()
    {
        if (rb)
        {
            rb.AddForce(movement); 
        }
    }

    #endregion
}

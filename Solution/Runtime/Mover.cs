using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Moves game object in specified direction
/// </summary>
public class Mover : MonoBehaviour
{
    #region FIELDS

    /// <summary>
    /// Object speed
    /// </summary>
    [SerializeField]
    private Vector2 speed = new Vector2(10f, 10f);

    /// <summary>
    /// Moveing direction
    /// </summary>
    [SerializeField]
    private Vector2 direction = new Vector2(-1f, 0f);

    /// <summary>
    /// Reference to Rigidbody2D component
    /// </summary>
    private Rigidbody2D rb;

    /// <summary>
    /// Stores movement values
    /// </summary>
    private Vector2 movement;

    #endregion

    #region PROPERTIES



    #endregion

    #region METHODS

    private void Awake()
    {
        if (!(rb = GetComponent<Rigidbody2D>()))
        {
            rb = gameObject.AddComponent<Rigidbody2D>();
        }

    }

    private void Update()
    {
        // Movement per direction
        movement = new Vector2(Time.deltaTime * speed.x * direction.x, Time.deltaTime * speed.y * direction.y);
    }

    private void FixedUpdate()
    {
        rb.velocity = movement;
    }

    #endregion
}

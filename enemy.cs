using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Enemy : MonoBehaviour
{
    public float speed = 2f;         // Geschwindigkeit des Gegners
    private bool movingRight = true; // Richtung des Gegners

    public Transform groundDetection; // Punkt zur Bodenerkennung

    void Update()
    {
        // Bewegung nach rechts oder links
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        // Überprüfung, ob Boden vor dem Gegner vorhanden ist
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, 2f);
        if (groundInfo.collider == false)
        {
            Flip();
        }
    }

    void Flip()
    {
        // Richtung umkehren
        movingRight = !movingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}


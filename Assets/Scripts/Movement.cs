using System.Runtime.CompilerServices;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MovementSpeed = 1;
    public float JumpForce = 1;
    private GameObject[] players;

    private Rigidbody2D _rigidbody;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        DontDestroyOnLoad(gameObject);
    }

    private void OnLevelWasLoaded(int level)
    {
        FindStartPos();

        players = GameObject.FindGameObjectsWithTag("Player");

        if(players.Length > 1)
        {
            Destroy(players[1]);
        }
        
    }
    void FindStartPos()
    {
      transform.position = GameObject.FindWithTag("StartPos").transform.position;
    }
    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f )
            {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
        
    }
}


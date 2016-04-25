using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody _rigidbody;
    private Vector3 _movement = new Vector3();
    public float speed = 1;

	void Awake () {
        _rigidbody = GetComponent<Rigidbody>();
    }
	
	void Update () {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        _movement = new Vector3(x, 0f, z);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane(Vector3.up, Vector3.zero);
        float distance;

        if (plane.Raycast (ray, out distance))
        {
            Vector3 point = ray.GetPoint(distance);
            Vector3 adjustedheightPoint = new Vector3(point.x, transform.position.y, point.z);
            transform.LookAt(adjustedheightPoint);
        }
    }

    void FixedUpdate()
    {
        Vector3 velocity = _movement * speed * Time.fixedDeltaTime;
        _rigidbody.MovePosition(_rigidbody.position + velocity);
    }
}

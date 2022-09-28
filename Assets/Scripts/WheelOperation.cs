using UnityEngine;
public class WheelOperation : MonoBehaviour
{
    Rigidbody wheelRB;
    public int speed = 1;
    private void Start()
    {
        if (GameObject.Find("Wheel").GetComponent<Rigidbody>() == null)
        {
            GameObject.Find("Wheel").AddComponent<Rigidbody>();
        }
        wheelRB = GameObject.Find("Wheel").GetComponent<Rigidbody>();
        wheelRB.useGravity = false;
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            wheelRB.MoveRotation(wheelRB.rotation * Quaternion.Euler(0, 0, speed));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            wheelRB.MoveRotation(wheelRB.rotation * Quaternion.Euler(0, 0, speed));
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            wheelRB.rotation = Quaternion.identity;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            speed += 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            speed = 1;
        }


    }
}
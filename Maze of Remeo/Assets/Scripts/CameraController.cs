using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

  public GameObject player;
  private float x;
  private float y;
  private Vector3 rotateValue;
  public float turnSpeed = 4.0f;
  private Vector3 offset;
  private float yaw = 0.1f;
  private float pitch = 0.1f;
  private float distance = 20.0f;
  private float height = 25.0f;
  private float heightDamping = 2.0f;
  private float rotationDamping = 3.0f;

  private Vector3 offsetPosition;
  private Space offsetPositionSpace = Space.Self;
  private bool lookAt = true;
  void Start()
  {
    // offset = player.transform.position - transform.position;
    // offset = new Vector3(transform.position.x, transform.position.y + 8.0f, transform.position.z + 7.0f);
    // offset = new Vector3(player.transform.position.x, player.transform.position.y, 0.0f);
  }


  // Update is called once per frame
  void LateUpdate()
  {
    // transform.position = player.transform.position + offset;

    // offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
    // transform.position = player.transform.position + offset;
    // transform.LookAt(player.transform);


    // float wantedRotationAngle = player.transform.eulerAngles.y;
    // float wantedHeight = player.transform.position.y + height;

    // float currentRotationAngle = transform.eulerAngles.y;
    // float currentHeight = transform.position.y;

    // // Damp the rotation around the y-axis
    // currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);

    // // Damp the height
    // currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);

    // // Convert the angle into a rotation
    // var currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);

    // // Set the position of the camera on the x-z plane to:
    // // distance meters behind the player.transform
    // transform.position = player.transform.position;
    // transform.position -= currentRotation * Vector3.forward * distance;

    // // Set the height of the camera
    // transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);

    // // Always look at the player.transform
    // transform.LookAt(player.transform);

    if (offsetPositionSpace == Space.Self)
    {
      transform.position = player.transform.TransformPoint(offsetPosition);
    }
    else
    {
      transform.position = player.transform.position + offsetPosition;
    }

    // compute rotation
    if (lookAt)
    {
      transform.LookAt(player.transform);
    }
    else
    {
      transform.rotation = player.transform.rotation;
    }
  }
}

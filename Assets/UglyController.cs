using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UglyController : MonoBehaviour
{
  private void OnCollisionEnter(Collision other)
  {
    // Destroy(this.gameObject);

    Vector3 newPosition = transform.position;

    newPosition.x = Random.Range(-2f, 2f);
    newPosition.y = Random.Range(.05f, 2f);

    transform.position = newPosition;
  }

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class HandController : MonoBehaviour
{

  ActionBasedController controller;

  void Awake()
  {
    controller = GetComponent<ActionBasedController>();

    controller.activateAction.action.started += OnTriggerPress;

  }

  void OnTriggerPress(InputAction.CallbackContext context)
  {
    Debug.Log("BANG!");
  }

  // Update is called once per frame
  void Update()
  {

  }
}

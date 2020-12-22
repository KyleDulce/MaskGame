using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace JLG.cooking.player 
{
    public class Player : MonoBehaviour
    {
        public float speed;
        public float rotSpeed;
        [SerializeField] private Transform Model;
        private CharacterController charController;
        private Vector2 curControls;
        private bool interactAction;

		private void Start()
		{
            charController = GetComponent<CharacterController>();
		}

        private void Update() {
            //Move player based on movement
            Vector3 movement = new Vector3(curControls.x, 0, curControls.y);
            charController.Move(movement * speed);

            //Rotate player based on input
            if (movement.magnitude != 0) {
                Model.rotation = Quaternion.Lerp(Model.rotation, Quaternion.LookRotation(movement), Time.deltaTime * rotSpeed);
            }
        }

		public void onMovement(InputAction.CallbackContext context) { 
            curControls = context.ReadValue<Vector2>();
        }

        public void onInteract(InputAction.CallbackContext context) => interactAction = true;

        public void onPickup(InputAction.CallbackContext context) => interactAction = true;
    }
}
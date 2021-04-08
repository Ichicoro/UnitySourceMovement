using UnityEngine;

namespace Fragsurf.Movement {

    public enum MoveType {
        None,
        Walk,
        Noclip, // not implemented
        Ladder, // not implemented
    }

    public class InputActions {
        public bool Jump = false;
        public bool Duck = false;
        public bool Speed = false;
        public float MoveRight = 0f;
        public float MoveForward = 0f;
        public bool HandAction = false;
        public bool HandAction2 = false;
        public bool Interact = false;
        public bool Slot1 = false;
        public bool Slot2 = false;
        public bool Slot3 = false;
        public bool Slot4 = false;
        public bool Slot5 = false;
        public bool Drop = false;
        public bool Reload = false;
        public bool NextItem = false;
        public bool PrevItem = false;
        public bool Brake = false;
        public bool Flashlight = false;
    }

    public class MoveData {
        ///// Fields /////
        public InputActions prevInputActions;
        public InputActions inputActions;
        public Transform playerTransform;
        public Transform viewTransform;
        public Vector3 viewTransformDefaultLocalPos;
        
        public Vector3 origin;
        public Vector3 viewAngles;
        public Vector3 velocity;
        public float forwardMove;
        public float sideMove;
        public float upMove;
        public float surfaceFriction = 1f;
        public float gravityFactor = 1f;
        public float walkFactor = 1f;
        public float verticalAxis = 0f;
        public float horizontalAxis = 0f;
        public bool wishJump = false;
        public bool crouching = false;
        public bool sprinting = false;

        public float slopeLimit = 45f;

        public float rigidbodyPushForce = 1f;

        public float defaultHeight = 2f;
        public float crouchingHeight = 1f;
        public float crouchingSpeed = 10f;
        public bool toggleCrouch = false;

        public bool slidingEnabled = false;
        public bool laddersEnabled = false;
        public bool angledLaddersEnabled = false;
        
        public bool climbingLadder = false;
        public Vector3 ladderNormal = Vector3.zero;
        public Vector3 ladderDirection = Vector3.forward;
        public Vector3 ladderClimbDir = Vector3.up;
        public Vector3 ladderVelocity = Vector3.zero;

        public bool underwater = false;
        public bool cameraUnderwater = false;

        public bool grounded = false;
        public bool groundedTemp = false;
        public float fallingVelocity = 0f;

        public bool useStepOffset = false;
        public float stepOffset = 0f; 

    }
}

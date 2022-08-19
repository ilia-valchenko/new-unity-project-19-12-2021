using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class JoystickMovementScript : MonoBehaviour
{
    public FixedJoystick MoveJoystick;
    public FixedButton JumpButton;
    public FixedTouchField TouchField;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var fps = this.GetComponent<RigidbodyFirstPersonController>();
        fps.RunAxis = this.MoveJoystick.Direction;
        fps.JumpAxis = this.JumpButton.Pressed;
        fps.mouseLook.LookAxis = this.TouchField.TouchDist;
    }
}

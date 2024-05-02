using System;
using UnityEngine;
public class IconBinding : MonoBehaviour
{
    public static IconBinding instance;
    public Icons allIcons;

    private void Awake()
    {
        instance = this;
    }

    [Serializable]
    public struct Icons
    {
        public Sprite buttonSouth;
        public Sprite buttonNorth;
        public Sprite buttonEast;
        public Sprite buttonWest;
        public Sprite leftTrigger;
        public Sprite rightTrigger;
        public Sprite leftShoulder;
        public Sprite rightShoulder;
        public Sprite dpadUp;
        public Sprite dpadDown;
        public Sprite dpadLeft;
        public Sprite dpadRight;
        public Sprite leftStick;
        public Sprite rightStick;
        public Sprite leftStickPress;
        public Sprite rightStickPress;
        public Sprite mouseRightClick;
        public Sprite mouseLeftClick;

        public Sprite GetSprite(string controlPath)
        {
            // From the input system, we get the path of the control on device. So we can just
            // map from that to the sprites we have for gamepads.
            switch (controlPath)
            {
                case "Button South": return buttonSouth;
                case "Button North": return buttonNorth;
                case "Button East": return buttonEast;
                case "Button West": return buttonWest;
                case "Left Trigger": return leftTrigger;
                case "Right Trigger": return rightTrigger;
                case "Left Shoulder": return leftShoulder;
                case "Right Shoulder": return rightShoulder;
                case "D-Pad/Up": return dpadUp;
                case "D-Pad/Down": return dpadDown;
                case "D-Pad/Left": return dpadLeft;
                case "D-Pad/Right": return dpadRight;
                case "Left Stick": return leftStick;
                case "Right Stick": return rightStick;
                case "Left Stick Press": return leftStickPress;
                case "Right Stick Press": return rightStickPress;
                case "Left Button": return mouseLeftClick;
                case "Right Button": return mouseRightClick;
            }
            return null;
        }
    }
}

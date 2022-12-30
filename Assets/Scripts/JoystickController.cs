using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ludiq;
using Bolt;

namespace NineD77
{
    public class JoystickController : MonoBehaviour
    {
        public Joystick joystick;

        public Vector2 direction => joystick.Direction;

        private void OnEnable()
        {
            Debug.LogWarning("Joystick Enabled");
        }
        private void OnDisable()
        {
            Debug.LogWarning("Joystick Disabled");
        }

        private void Start()
        {
            Debug.Log("Joystick start");
        }

        private void Update()
        {
            if (null != joystick)
            {
                Variables.Application.Set("InputAxis", joystick.Direction);
            }
        }
    }

}
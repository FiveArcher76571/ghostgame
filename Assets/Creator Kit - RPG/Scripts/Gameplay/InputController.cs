using RPGM.Core;
using RPGM.Gameplay;
using UnityEngine;
using System;

namespace RPGM.UI
{
    /// <summary>
    /// Sends user input to the correct control systems.
    /// </summary>
    public class InputController : MonoBehaviour
    {
        public float stepSize = 0.1f;
        GameModel model = Schedule.GetModel<GameModel>();

        public enum State
        {
            CharacterControl,
            DialogControl,
            Pause
        }

        State state;

        public void ChangeState(State state) => this.state = state;

        void Update()
        {
            switch (state)
            {
                case State.CharacterControl:
                    CharacterControl();
                    break;
                case State.DialogControl:
                    DialogControl();
                    break;
            }
        }

        void DialogControl()
        {
            model.player.nextMoveCommand = Vector3.zero;
            if (Input.GetKeyDown(KeyCode.A))
                model.dialog.FocusButton(-1);
            else if (Input.GetKeyDown(KeyCode.D))
                model.dialog.FocusButton(+1);
            if (Input.GetKeyDown(KeyCode.Space))
                model.dialog.SelectActiveButton();
        }

        void CharacterControl()
        {
            double temp = 1/Math.Sqrt(2);
            float root2;
            root2 = (float)temp;
            if (Input.GetKey(KeyCode.W)) {
                if (Input.GetKey(KeyCode.D)) {
                    model.player.nextMoveCommand = (Vector3.up + Vector3.right) * root2 * stepSize;
                }
                else if (Input.GetKey(KeyCode.A)) {
                    model.player.nextMoveCommand = (Vector3.up + Vector3.left) * root2 * stepSize;
                }
                else {
                    model.player.nextMoveCommand = Vector3.up * stepSize;
                }
            }
            else if (Input.GetKey(KeyCode.S)) {
                if (Input.GetKey(KeyCode.D)) {
                    model.player.nextMoveCommand = (Vector3.down + Vector3.right) * root2 * stepSize;
                }
                else if (Input.GetKey(KeyCode.A)) {
                    model.player.nextMoveCommand = (Vector3.down + Vector3.left) * root2 * stepSize;
                }
                else {
                    model.player.nextMoveCommand = Vector3.down * stepSize;
                }
            }

            else if (Input.GetKey(KeyCode.A)) {
                model.player.nextMoveCommand = Vector3.left * stepSize;
            }
            else if (Input.GetKey(KeyCode.D)) {
                model.player.nextMoveCommand = Vector3.right * stepSize;
            }                
            else {
                model.player.nextMoveCommand = Vector3.zero;
            }

            if (Input.GetKey(KeyCode.LeftShift)) {
                stepSize = 0.2f;
            }
            else {
                stepSize = 0.1f;
            }

        }
    }
}
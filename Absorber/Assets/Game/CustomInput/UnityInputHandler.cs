using System;
using System.Collections;
using System.Collections.Generic;
using Game.Enums;
//using Game.CharacterStates;
using Game.Components;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;
using EcsRx.Unity.MonoBehaviours;
using EcsRx.Groups;
using EcsRx.Groups.Observable;
using UniRx;
using Zenject;
//I hope I can refactor DRY section later!

namespace Game.CustomInput {
    public class UnityInputHandler : MonoBehaviour, PlayerUnityInputAsset.IPlayer0CombatActions, IDisposable {
        private PlayerUnityInputAsset _playerUnityInputAsset;
        private InputAction _movement;
        private InputAction _primaryAttack;
        


        [Inject]
        public void Construct() {
            _playerUnityInputAsset = new PlayerUnityInputAsset();

            #region Movement
            _movement = _playerUnityInputAsset.Player0Combat.Movement;
           
            _movement.started += OnMovementStarted;
       
            _movement.performed += OnMovementPerformed;
            _movement.canceled += OnMovementCanceled;
            IsMoving.Value = false;
            #endregion

         


            _playerUnityInputAsset.Player0Combat.SetCallbacks(this);

        }


        #region Movement
        public Vector3ReactiveProperty VelocityByMovement = new Vector3ReactiveProperty();
        private Vector3 _currentVelocity;
        public BoolReactiveProperty IsMoving = new BoolReactiveProperty();


        private Vector3 ReadValueFromMovementAxis(InputAction.CallbackContext context) {
            _currentVelocity.x = context.ReadValue<Vector2>().x;
            _currentVelocity.y = context.ReadValue<Vector2>().y;
            return _currentVelocity;
        }
        private void ToggleIsMoving() {
            IsMoving.Value = !IsMoving.Value;
        }
        public void OnMovement(InputAction.CallbackContext context) {
            //throw new System.NotImplementedException();
        }
        private void OnMovementStarted(InputAction.CallbackContext context) {
            VelocityByMovement.Value = ReadValueFromMovementAxis(context);
            ToggleIsMoving();

        }
        private void OnMovementPerformed(InputAction.CallbackContext context) {
            VelocityByMovement.Value = ReadValueFromMovementAxis(context);
        }
        private void OnMovementCanceled(InputAction.CallbackContext context) {
            VelocityByMovement.Value = ReadValueFromMovementAxis(context);
            ToggleIsMoving();
        }
        #endregion

        #region PrimaryAttack
        public void OnPrimaryAttack(InputAction.CallbackContext context) {
            throw new System.NotImplementedException();
        }
        private void OnPrimaryAttackChanged(InputAction.CallbackContext context) {
            //context.interaction.
        }
        #endregion
        #region Enable/Disable
        private void OnDisable() {
            _playerUnityInputAsset.Disable();
        }

        private void OnEnable() {
            _playerUnityInputAsset.Enable();
        }
        #endregion
        public void Dispose() {
            VelocityByMovement.Dispose();
        }

        //public class Factory : PlaceholderFactory<UnityInputWrapper>
        //{
        //}

    }

}

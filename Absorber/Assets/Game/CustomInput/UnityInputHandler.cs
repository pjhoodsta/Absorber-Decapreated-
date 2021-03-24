using System;
using System.Collections;
using System.Collections.Generic;
using Game.Enums;
using Game.CharacterStates;
using Game.Components;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;
using EcsRx.Components;
using EcsRx.Unity.MonoBehaviours;
using UniRx;
using Zenject;
//I hope I can refactor DRY section later!

namespace Game.CustomInput {
    public class UnityInputHandler : MonoBehaviour, PlayerUnityInputAsset.IPlayer0GameplayActions, IDisposable {
        private PlayerUnityInputAsset _playerUnityInputAsset;
        private InputAction _movement;
        private InputAction _primaryAttack;
        private InputAction _secondaryAttack;
        private InputAction _jump;
        private InputAction _grab;
        private InputAction _defense;
        private InputAction _primarySpecial;
        private InputAction _secondarySpecial;
        private InputAction _tertiarySpecial;
        private InputAction _selection;

<<<<<<< HEAD
=======
        public StandardInputComponent StandardInputComponent;

>>>>>>> 360c0ddab0ea31d3baa9ea4829d4f93dcc515d1f
        [Inject]
        public void Construct(StandardInputComponent standardInputComponent) {
            StandardInputComponent = standardInputComponent;
            _playerUnityInputAsset = new PlayerUnityInputAsset();

            #region Movement
            _movement = _playerUnityInputAsset.Player0Gameplay.Movement;
           
            _movement.started += OnMovementStarted;
            //_movement.started += context => {
            //    if (context.interaction is MultiTapInteraction)
            //};
            _movement.performed += OnMovementPerformed;
            _movement.canceled += OnMovementCanceled;
            #endregion

            #region PrimaryAttack
            _primaryAttack = _playerUnityInputAsset.Player0Gameplay.PrimaryAttack;
            _primaryAttack.started += OnPrimaryAttackChanged;
            _primaryAttack.performed += OnPrimaryAttackChanged;
            _primaryAttack.canceled += OnPrimaryAttackChanged;
            #endregion

            #region SecondaryAttack
            _secondaryAttack = _playerUnityInputAsset.Player0Gameplay.SecondaryAttack;
            _secondaryAttack.started += OnSecondaryAttackChanged;
            _secondaryAttack.performed += OnSecondaryAttackChanged;
            _secondaryAttack.canceled += OnSecondaryAttackChanged;
            #endregion

            #region Jump
            _jump = _playerUnityInputAsset.Player0Gameplay.Jump;
            _jump.started += OnJumpChanged;
            _jump.performed += OnJumpChanged;
            _jump.canceled += OnJumpChanged;
            #endregion

            #region Grab
            _grab = _playerUnityInputAsset.Player0Gameplay.Grab;
            _grab.started += OnGrabChanged;
            _grab.performed += OnGrabChanged;
            _grab.canceled += OnGrabChanged;
            #endregion

            #region Defense
            _defense = _playerUnityInputAsset.Player0Gameplay.Defense;
            _defense.started += OnDefenseChanged;
            _defense.performed += OnDefenseChanged;
            _defense.canceled += OnDefenseChanged;
            #endregion

            #region PrimarySpecial
            _primarySpecial = _playerUnityInputAsset.Player0Gameplay.PrimarySpecial;
            _primarySpecial.started += OnPrimarySpecialChanged;
            _primarySpecial.performed += OnPrimarySpecialChanged;
            _primarySpecial.canceled += OnPrimarySpecialChanged;
            #endregion

            #region SecondarySpecial
            _secondarySpecial = _playerUnityInputAsset.Player0Gameplay.SecondarySpecial;
            _secondarySpecial.started += OnSecondarySpecialChanged;
            _secondarySpecial.performed += OnSecondarySpecialChanged;
            _secondarySpecial.canceled += OnSecondarySpecialChanged;
            #endregion

            #region TertiarySpecial
            _tertiarySpecial = _playerUnityInputAsset.Player0Gameplay.TertiarySpecial;
            _tertiarySpecial.started += OnTertiarySpecialChanged;
            _tertiarySpecial.performed += OnTertiarySpecialChanged;
            _tertiarySpecial.canceled += OnTertiarySpecialChanged;
            #endregion

            #region Selection
            _selection = _playerUnityInputAsset.Player0Gameplay.Selection;
            _selection.started += OnSelectionChanged;
            _selection.performed += OnSelectionChanged;
            _selection.canceled += OnSelectionChanged;
            #endregion

            _playerUnityInputAsset.Player0Gameplay.SetCallbacks(this);

        }


        #region Movement
<<<<<<< HEAD
        public Vector3ReactiveProperty VelocityByMovement = new Vector3ReactiveProperty();
        private Vector3 _tempVelocity;
=======
        //private Vector2 _velocityByMovement;
        //public Vector2 VelocityByMovement {
        //    get { return _velocityByMovement; }
        //}
        public Vector2ReactiveProperty VelocityByMovement;
>>>>>>> 360c0ddab0ea31d3baa9ea4829d4f93dcc515d1f

        private int _movementState;
        public int MovementState {
            get { return _movementState; }
        }
        private int _entityState;
        public int EntityState {
            get { return _entityState; }
        }


        public void OnMovement(InputAction.CallbackContext context) {
            //throw new System.NotImplementedException();
        }
        private void OnMovementStartedWalking(InputAction.CallbackContext context) {
            if (_entityState == EntityStates.Idle) {
                _movementState = MovementStates.Walk;
                _entityState = EntityStates.Movement;
            }
               
        }
        private void OnMovementStartedRunning(InputAction.CallbackContext context) {
            if (_entityState == EntityStates.Idle) {
                _movementState = MovementStates.Run;
                _entityState = EntityStates.Movement;
            }
        }
        private void OnMovementStarted(InputAction.CallbackContext context) {
<<<<<<< HEAD
            _tempVelocity.x = context.ReadValue<Vector2>().x;
            _tempVelocity.y = context.ReadValue<Vector2>().y;

            VelocityByMovement.Value = _tempVelocity;

            //if (context.interaction is PressInteraction) {
            //    if (_entityState == EntityStates.Idle)
            //        _movementState = MovementStates.Walk;
            //}
            //else if (context.interaction is HoldInteraction) {
            //    _movementState = MovementStates.Run;
            //}
            //if (_entityState == EntityStates.Idle) _entityState = EntityStates.Movement;
        }
        private void OnMovementPerformed(InputAction.CallbackContext context) {
            _tempVelocity.x = context.ReadValue<Vector2>().x;
            _tempVelocity.y = context.ReadValue<Vector2>().y;

            VelocityByMovement.Value = _tempVelocity;
            //if (context.interaction is PressInteraction) {
            //    if (_entityState == EntityStates.Idle)
            //        _movementState = MovementStates.Walk;
            //} else if (context.interaction is HoldInteraction) {
            //    _movementState = MovementStates.Run;
            //}
            //if (_entityState == EntityStates.Idle) _entityState = EntityStates.Movement;

        }
        private void OnMovementCanceled(InputAction.CallbackContext context) {
            _tempVelocity.x = context.ReadValue<Vector2>().x;
            _tempVelocity.y = context.ReadValue<Vector2>().y;

            VelocityByMovement.Value = _tempVelocity;
            //if (_entityState == EntityStates.Movement)
            //    _entityState = EntityStates.Idle;
=======
            StandardInputComponent.VelocityByMovement.Value = context.ReadValue<Vector2>();
            if (context.interaction is PressInteraction) {
                if (_entityState == EntityStates.Idle)
                    _movementState = MovementStates.Walk;
            }
            else if (context.interaction is HoldInteraction) {
                _movementState = MovementStates.Run;
            }
            if (_entityState == EntityStates.Idle) _entityState = EntityStates.Movement;
        }
        private void OnMovementPerformed(InputAction.CallbackContext context) {
            StandardInputComponent.VelocityByMovement.Value = context.ReadValue<Vector2>();
            if (context.interaction is PressInteraction) {
                if (_entityState == EntityStates.Idle)
                    _movementState = MovementStates.Walk;
            } else if (context.interaction is HoldInteraction) {
                _movementState = MovementStates.Run;
            }
            if (_entityState == EntityStates.Idle) _entityState = EntityStates.Movement;

        }
        private void OnMovementCanceled(InputAction.CallbackContext context) {
            StandardInputComponent.VelocityByMovement.Value = context.ReadValue<Vector2>();
            if (_entityState == EntityStates.Movement)
                _entityState = EntityStates.Idle;
>>>>>>> 360c0ddab0ea31d3baa9ea4829d4f93dcc515d1f
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
        #region SecondaryAttack
        public void OnSecondaryAttack(InputAction.CallbackContext context) {
            throw new System.NotImplementedException();
        }
        private void OnSecondaryAttackChanged(InputAction.CallbackContext context) {

        }
        #endregion
        #region Jump
        public void OnJump(InputAction.CallbackContext context) {
            throw new System.NotImplementedException();
        }
        private void OnJumpChanged(InputAction.CallbackContext context) {

        }
        #endregion
        #region Grab
        public void OnGrab(InputAction.CallbackContext context) {
            throw new System.NotImplementedException();
        }
        private void OnGrabChanged(InputAction.CallbackContext context) {

        }
        #endregion
        #region Defense
        public void OnDefense(InputAction.CallbackContext context) {
            throw new System.NotImplementedException();
        }
        private void OnDefenseChanged(InputAction.CallbackContext context) {

        }
        #endregion
        #region PrimarySpecial
        public void OnPrimarySpecial(InputAction.CallbackContext context) {
            throw new System.NotImplementedException();
        }
        private void OnPrimarySpecialChanged(InputAction.CallbackContext context) {

        }
        #endregion
        #region SecondarySpecial
        public void OnSecondarySpecial(InputAction.CallbackContext context) {
            throw new System.NotImplementedException();
        }
        private void OnSecondarySpecialChanged(InputAction.CallbackContext context) {

        }
        #endregion
        #region TertiarySpecial
        public void OnTertiarySpecial(InputAction.CallbackContext context) {
            throw new System.NotImplementedException();
        }
        private void OnTertiarySpecialChanged(InputAction.CallbackContext context) {

        }
        #endregion
        #region Selection
        public void OnSelection(InputAction.CallbackContext context) {
            throw new System.NotImplementedException();
        }
        private void OnSelectionChanged(InputAction.CallbackContext context) {

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
<<<<<<< HEAD
        public void Dispose() {
            VelocityByMovement.Dispose();
        }

        //public class Factory : PlaceholderFactory<UnityInputWrapper>
        //{
        //}
=======
       
        public class Factory : PlaceholderFactory<UnityInputHandler>
        {
        }
>>>>>>> 360c0ddab0ea31d3baa9ea4829d4f93dcc515d1f

    }

}

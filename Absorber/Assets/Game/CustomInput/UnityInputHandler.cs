using System;
using System.Collections;
using System.Collections.Generic;
using Game.Enums;
using Game.Components;
using UnityEngine;
using UnityEngine.InputSystem;
using EcsRx.Unity.MonoBehaviours;
using Zenject;
//I hope I can refactor DRY section later!

namespace Game.CustomInput {
    public class UnityInputHandler : MonoBehaviour, PlayerUnityInputAsset.IPlayer0GameplayActions{
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

        StandardInputComponent _standardInputComponent;

        [Inject]
        public void Construct() {
            _playerUnityInputAsset = new PlayerUnityInputAsset();

            #region Movement
            _movement = _playerUnityInputAsset.Player0Gameplay.Movement;
            _movement.started += OnMovementChanged;
            _movement.performed += OnMovementChanged;
            _movement.canceled += OnMovementChanged;
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
        private Vector2 _velocityByMovement;
        public Vector2 VelocityByMovement {
            get { return _velocityByMovement; }
        }

        public void OnMovement(InputAction.CallbackContext context)
        {
            throw new System.NotImplementedException();
        }

        private void OnMovementChanged(InputAction.CallbackContext context)
        {
            _velocityByMovement = context.ReadValue<Vector2>();
        }
        #endregion

        #region PrimaryAttack
        public void OnPrimaryAttack(InputAction.CallbackContext context)
        {
            throw new System.NotImplementedException();
        }
        private void OnPrimaryAttackChanged(InputAction.CallbackContext context)
        {
            //context.interaction.
        }
        #endregion
        #region SecondaryAttack
        public void OnSecondaryAttack(InputAction.CallbackContext context)
        {
            throw new System.NotImplementedException();
        }
        private void OnSecondaryAttackChanged(InputAction.CallbackContext context)
        {

        }
        #endregion
        #region Jump
        public void OnJump(InputAction.CallbackContext context)
        {
            throw new System.NotImplementedException();
        }
        private void OnJumpChanged(InputAction.CallbackContext context)
        {

        }
        #endregion
        #region Grab
        public void OnGrab(InputAction.CallbackContext context)
        {
            throw new System.NotImplementedException();
        }
        private void OnGrabChanged(InputAction.CallbackContext context)
        {

        }
        #endregion
        #region Defense
        public void OnDefense(InputAction.CallbackContext context)
        {
            throw new System.NotImplementedException();
        }
        private void OnDefenseChanged(InputAction.CallbackContext context)
        {

        }
        #endregion
        #region PrimarySpecial
        public void OnPrimarySpecial(InputAction.CallbackContext context)
        {
            throw new System.NotImplementedException();
        }
        private void OnPrimarySpecialChanged(InputAction.CallbackContext context)
        {

        }
        #endregion
        #region SecondarySpecial
        public void OnSecondarySpecial(InputAction.CallbackContext context)
        {
            throw new System.NotImplementedException();
        }
        private void OnSecondarySpecialChanged(InputAction.CallbackContext context)
        {

        }
        #endregion
        #region TertiarySpecial
        public void OnTertiarySpecial(InputAction.CallbackContext context)
        {
            throw new System.NotImplementedException();
        }
        private void OnTertiarySpecialChanged(InputAction.CallbackContext context)
        {

        }
        #endregion
        #region Selection
        public void OnSelection(InputAction.CallbackContext context)
        {
            throw new System.NotImplementedException();
        }
        private void OnSelectionChanged(InputAction.CallbackContext context)
        {

        }
        #endregion
        #region Enable/Disable
        private void OnDisable()
        {
            _playerUnityInputAsset.Disable();
        }

        private void OnEnable()
        {
            _playerUnityInputAsset.Enable();
        }
        #endregion
        //public class Factory : PlaceholderFactory<UnityInputWrapper>
        //{
        //}

    }
  
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro;
using System;

[RequireComponent(typeof(Button))]
public class KeyBoundButton : MonoBehaviour
{
    private InputAction buttonPress;
    [SerializeField] private InputActionAsset controls;
    [HideInInspector]
    public PlayerInput input;
    private InputActionMap _inputActionMap;
    Button button;
    public string ActionName;
    public TextMeshProUGUI bindText;
    string currentScheme;
    public bool doOnButtonRelease = false;
    public KBindOverride bindOverride;

    private void Start()
    {
        SetInput();
        if(input == null)
        {
            InvokeRepeating("SetInput", 1, 1);
        }
    }

    private void SetInput()
    {

        input = FindFirstObjectByType<PlayerInput>();
        button = GetComponent<Button>();
        currentScheme = input.defaultControlScheme;
        if(input != null) { CancelInvoke(); }
    }

    private void CheckBinding()
    {
        if(currentScheme != input.currentControlScheme)
        {
            currentScheme = input.currentControlScheme;
            SetBinding();
        }
    }

    private void OnEnable()
    {
        InvokeRepeating("CheckBinding", 0.5f, 0.5f);
        _inputActionMap = controls.FindActionMap("Gameplay");
        buttonPress = _inputActionMap.FindAction(ActionName);

        SetBinding();

        if(doOnButtonRelease) { buttonPress.canceled += OnInputAction; }
        else { buttonPress.performed += OnInputAction; }
        
    }

    void SetBinding()
    {
        if (bindText == null) { return; }
        bindText.text = buttonPress.GetBindingDisplayString();
        if(buttonPress.GetBindingDisplayString() == bindOverride.officialName) { bindText.text = bindOverride.overrideName; }
    }

    private void OnDisable()
    {
        CancelInvoke();
        if (doOnButtonRelease) { buttonPress.canceled -= OnInputAction; }
        else { buttonPress.performed -= OnInputAction; }
    }

    public virtual bool checkCanPress()
    {
        return true;
    }

    private void OnInputAction(InputAction.CallbackContext obj)
    {
        Debug.Log("PRESSED " + name);
        if(checkCanPress())
        {
            button.onClick.Invoke();
        }
    }
}

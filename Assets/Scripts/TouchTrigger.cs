using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

public class TouchTrigger : MonoBehaviour, IPointerDownHandler, ISubmitHandler
{
    [Serializable]
    /// <summary>
    /// Function definition for a button click event.
    /// </summary>
    public class ButtonClickedEvent : UnityEvent { }

    // Event delegates triggered on click.
    [FormerlySerializedAs("onClick")]
    [SerializeField]
    private ButtonClickedEvent m_OnClick = new ButtonClickedEvent();

    public ButtonClickedEvent onClick
    {
        get { return m_OnClick; }
        set { m_OnClick = value; }
    }

    public bool IsActive() => isActiveAndEnabled;
    public bool IsInteractable() => true;

    private void Start()
    {
        
    }

    private void Press()
    {
        if (!IsActive() || !IsInteractable())
            return;

        UISystemProfilerApi.AddMarker("Button.onClick", this);
        m_OnClick.Invoke();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Press();
    }

    public void OnSubmit(BaseEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}

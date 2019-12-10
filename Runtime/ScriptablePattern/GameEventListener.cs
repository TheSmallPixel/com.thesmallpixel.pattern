using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [Tooltip("Event to register with.")]
    public GameEvent Event;

    [Tooltip("Response to invoke when Event is raised.")]
    public UnityEvent Response;
    public void Awake()
    {
        Event.RegisterListener(this);
    }

    public void Enable()
    {
        Event.RegisterListener(this);
    }

    private void Disable()
    {
        Event.UnregisterListener(this);
    }

    public void OnEventRaised()
    {
        Debug.Log("Recived");
        Response.Invoke();
    }
}
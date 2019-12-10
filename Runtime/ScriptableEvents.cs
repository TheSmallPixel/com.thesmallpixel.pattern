using System;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.Events;

namespace DesignPatterns.ScriptableEvents
{
#if UNITY_EDITOR
    [CustomEditor(typeof(GameEvent))]
    public class EventEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            GameEvent e = target as GameEvent;
            if (GUILayout.Button("Raise"))
                e.Raise();
        }
    }
    
#endif
   
    
    [CreateAssetMenu]
    public abstract class ScriptableObjectList<T> : ScriptableObject where T : Set
    {
        public List<T> Items = new List<T>();

        public void Add(T thing)
        {
            if (!Items.Contains(thing))
                Items.Add(thing);
        }

        public void Remove(T thing)
        {
            if (Items.Contains(thing))
                Items.Remove(thing);
        }
    }

    public abstract class Set : MonoBehaviour
    {
        public ScriptableObjectList<Set> scriptableObjectList;


    }
}
namespace DesignPatterns.ScriptableEvents.Variables
{

    public abstract class GenericVar<T> : ScriptableObject
    {
        public GameEvent EventOnChange;
#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public T Value;

        public T GetValue { get { return Value; } set { this.Value = value; EventOnChange.Raise(); } }

        public static implicit operator T(GenericVar<T> reference)
        {
            return reference.GetValue;
        }

    }



}
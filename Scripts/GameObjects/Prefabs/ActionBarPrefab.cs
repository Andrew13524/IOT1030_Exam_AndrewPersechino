using Assets.Scripts.GameObjects.Prefabs;
using Assets.Scripts.Input;
using Assets.Scripts.Models;
using System;
using UnityEngine;

namespace Assets.Scripts.GameObjects
{
    public class ActionBarPrefab: MonoBehaviour
    {
        public GameObject[] ActionNotePrefabs;
        public static byte[] PressedNotes => InputDevice.PressedNotes();
        public static Vector2 screenBounds;
        public static float ActionNoteY => (float)Math.Round(screenBounds.y, 1);
        private void Start()
        {
            screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

            InstantiateActionNotes();
        }

        public void InstantiateActionNotes()
        {
            foreach (var actionNotePrefab in ActionNotePrefabs)
            {
                ActionNotePrefab actionNote = actionNotePrefab.GetComponent<ActionNotePrefab>();
                actionNotePrefab.transform.Translate(
                    new Vector3(
                        (float)actionNote.Key + Constants.NOTE_HORIZONTAL_OFFSET + (Constants.NOTE_HORIZONTAL_PADDING * (float)actionNote.Key), 
                        ActionNoteY,
                        0));
            }
        }
    }
}

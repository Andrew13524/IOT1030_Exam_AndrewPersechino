using Assets.Scripts.GameObjects;
using Assets.Scripts.GameObjects.Scenes;
using Assets.Scripts.GameObjects.UI.Text;
using Assets.Scripts.Models;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.GameObjects.UI.Text
{
    public class StreakText : MonoBehaviour
    {
        void Update()
        {
            gameObject.GetComponent<TextMeshProUGUI>().text = $"Streak {NoteHighway.Streak}";
        }
    }
}

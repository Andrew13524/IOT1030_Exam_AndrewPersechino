using Assets.Scripts.GameObjects.Scenes;
using Assets.Scripts.Models;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.GameObjects.UI.Text
{
    public class ScoreText : MonoBehaviour
    {
        private void Update()
        {
            gameObject.GetComponent<TextMeshProUGUI>().text = $"Score {NoteHighway.Score}";
        }
    }
}

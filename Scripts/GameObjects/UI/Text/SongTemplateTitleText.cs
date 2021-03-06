using TMPro;
using UnityEngine;

namespace Assets.Scripts.GameObjects.UI.Text
{
    public class SongTemplateTitleText : MonoBehaviour
    {
        private void Start()
        {
            var songTemplate = gameObject.GetComponentInParent(typeof(SongTemplatePrefab)) as SongTemplatePrefab;
            gameObject.GetComponent<TextMeshProUGUI>().text = songTemplate.Song.Title;
        }
    }
}

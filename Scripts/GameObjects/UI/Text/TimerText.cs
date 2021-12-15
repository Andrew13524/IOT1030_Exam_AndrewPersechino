using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.GameObjects.UI.Text
{
    public class TimerText : MonoBehaviour
    {
        private void Update()
        {
            gameObject.GetComponent<TextMeshProUGUI>().text = $"{Math.Round(GameObjects.TimerPrefab.CurrentTime, 2)}";
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.GameObjects
{
    public class TimerPrefab : MonoBehaviour
    {
        public static float CurrentTime;
        static bool isTimerOn;

        private void Start()
        {
            CurrentTime = .0f;

            StartTimer();
        }

        private void Update()
        {
            if (isTimerOn)
            {
                CurrentTime += Time.deltaTime;
            }

            if (UnityEngine.Input.GetKeyDown(KeyCode.R))
                Restart();
        }

        public void Restart()
        {
            CurrentTime = 0;
        }

        public static void StartTimer()
        {
            isTimerOn = true;
        }

        public static void StopTimer()
        {
            isTimerOn = false;
        }
    }
}

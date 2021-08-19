using UnityModManagerNet;
using ModKit;
using UnityEngine;

namespace SolastaFasterTimeScale.Viewers
{
    public class ModSettingsViewer : IMenuSelectablePage
    {
        public string Name => "Options";

        public int Priority => 0;

        public static float CustomTimeScale = 1.5f;

        public static bool PermanentSpeedUp = false;

        public void OnGUI(UnityModManager.ModEntry modEntry)
        {
            if (Main.Mod == null) return;

            GUILayout.Label("Speed Up Battle speed", UnityModManager.UI.bold, GUILayout.ExpandWidth(false));

            PermanentSpeedUp = GUILayout.Toggle(PermanentSpeedUp, "Permanent Speed Up Battle");

            GUILayout.BeginHorizontal();
            GUILayout.Label("Timescale", GUILayout.ExpandWidth(false));
            GUILayout.Space(10);
            CustomTimeScale = GUILayout.HorizontalSlider(CustomTimeScale, 1.5f, 50f, GUILayout.Width(300f));
            GUILayout.Label($" {CustomTimeScale}", GUILayout.ExpandWidth(false));
            GUILayout.EndHorizontal();
        }
    }
}
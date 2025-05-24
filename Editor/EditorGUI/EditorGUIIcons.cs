using UnityEditor;
using UnityEngine;

namespace MFramework.EditorExtensions
{
    public static class EditorGUIIcons
    {
        public static GUIContent PackageInstalled { get; }
        public static GUIContent UnityLoge { get; }
        public static Texture Github { get; }
        public static Texture Gitee { get; }
        public static Texture Home { get; }
        public static Texture KerryCommunity { get; }
        public static Texture MagicBoxCommunity { get; }
        public static Texture TaikrCommunity { get; }
        public static Texture UnityCommunity { get; }
        public static Texture FantasyCommunity { get; }
        public static Texture LotusLeafCheckGree { get; }

        static EditorGUIIcons()
        {
            PackageInstalled = EditorGUIUtility.IconContent("package_installed");
            UnityLoge = EditorGUIUtility.IconContent("UnityLogo");
            Github = Resources.Load<Texture>("Icons/icons-github-128");
            Gitee = Resources.Load<Texture>("Icons/icons-gitee-64");
            Home = Resources.Load<Texture>("Icons/Home_icon");
            KerryCommunity = Resources.Load<Texture>("Icons/KerryCommunity_Icon");
            MagicBoxCommunity = Resources.Load<Texture>("Icons/MagicBoxCommunity_Icon");
            TaikrCommunity = Resources.Load<Texture>("Icons/TaikrCommunity_Icon");
            UnityCommunity = Resources.Load<Texture>("Icons/UnityCommunity_Icon");
            FantasyCommunity = Resources.Load<Texture>("Icons/FantasyCommunity_Icon");
            LotusLeafCheckGree = Resources.Load<Texture>("Icons/icons8-lotusLeafCheck-green-32");
        }
    }
}
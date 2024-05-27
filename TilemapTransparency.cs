// **************************************************************** //
//
//   Copyright (c) RimuruDev. All rights reserved.
//   Contact me: 
//          - Gmail:    rimuru.dev@gmail.com
//          - LinkedIn: https://www.linkedin.com/in/rimuru/
//          - GitHub:   https://github.com/RimuruDev
//
// **************************************************************** //

using UnityEngine;
using UnityEngine.Tilemaps;

namespace AbyssMoth
{
    [SelectionBase]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Tilemap))]
    [HelpURL("https://github.com/RimuruDev/Unity-TilemapTransparency")]
    public sealed class TilemapTransparency : MonoBehaviour
    {
        [field: SerializeField, Range(0f, 1f)] public float Transparency { get; private set; } = 0.5f;

        private void OnValidate() =>
            UpdateTransparency();

        private void UpdateTransparency()
        {
            var tilemap = GetComponent<Tilemap>();

            if (tilemap != null)
                tilemap.color = new Color(1f, 1f, 1f, Transparency);
        }

#if UNITY_EDITOR
        private void OnDrawGizmos() =>
            UpdateTransparency();
#endif
    }
}

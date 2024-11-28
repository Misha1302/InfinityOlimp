using System.Linq;
using UnityEngine;

namespace Sharp
{
    public class SceneTag : MonoBehaviour
    {
        [field: SerializeField] public int Index { get; private set; }

        private void OnValidate()
        {
            if (Index != 0) return;

            var scenes = FindObjectsByType<SceneTag>(FindObjectsInactive.Include, FindObjectsSortMode.None);
            var maxIndex = scenes.Max(x => x.Index);
            Index = maxIndex + 1;
        }
    }
}
using UnityEngine;

namespace NTC.Global.Cache
{
    [RequireComponent(typeof(NightCacheInstallMachine))]
    public abstract class NightCache : MonoBehaviour, INightCached
    {
        private GameObject cachedGameObject;
        private Transform cachedTransform;
        
        private bool systemIsActiveInScene;

        public GameObject CachedGameObject => cachedGameObject ??= gameObject;
        public Transform CachedTransform => cachedTransform ??= transform;

        public bool IsActive()
        {
            return systemIsActiveInScene;
        }

        public void SetNightCacheSystemActive(bool status)
        {
            systemIsActiveInScene = status;
        }
    }
}
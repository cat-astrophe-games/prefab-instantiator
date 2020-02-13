using System.Collections.Generic;

using UnityEngine;

namespace Utilities
{
    public class PrefabInstantiator : MonoBehaviour
    {
        [SerializeField] public GameObject prefabToInstantiate;

        private List<GameObject> InstantiatedObjects = new List<GameObject>();

        public T Instantiate<T>()
        {
            return this.Instantiate().GetComponent<T>();
        }

        public GameObject Instantiate()
        {
            GameObject newObject = Instantiate(prefabToInstantiate, this.transform, false);
            this.InstantiatedObjects.Add(newObject);
            return newObject;
        }

    }
}
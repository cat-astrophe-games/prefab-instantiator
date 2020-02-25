using System.Collections.Generic;

using UnityEngine;

<<<<<<< HEAD
namespace CatastropheGames.PrefabInstantiator
=======
namespace Utilities
>>>>>>> 0219fcf659bd0809c9c53f8ee2778dcc6667295f
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
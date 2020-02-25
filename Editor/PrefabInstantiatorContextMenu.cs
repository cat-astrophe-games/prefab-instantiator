using UnityEditor;
using UnityEngine;
<<<<<<< HEAD

namespace CatastropheGames.PrefabInstantiator
{
    public static class PrefabInstantiatorContextMenu
    {

        [MenuItem("GameObject/Prefab Instantiator/Instantiate", false, 1)]
        public static void Instantiate()
        {
            Instantiate(Selection.activeObject);
        }

        private static void Instantiate(UnityEngine.Object selectedObject)
        {

            foreach (PrefabInstantiator instantiator in (selectedObject as GameObject).transform.GetComponentsInChildren<PrefabInstantiator>(true))
            {
                Instantiate(instantiator.prefabToInstantiate, instantiator.gameObject);
            }
        }

        private static void Instantiate(GameObject prefab, GameObject parent)
        {
            (PrefabUtility.InstantiatePrefab(prefab) as GameObject).transform.SetParent(parent.transform, false);
        }
=======
using Utilities;

public static class PrefabInstantiatorContextMenu
{

    [MenuItem("GameObject/Prefab Instantiator/Instantiate")]
    private static void Instantiate()
    {
        Instantiate(Selection.activeObject);
    }

    private static void Instantiate(UnityEngine.Object selectedObject)
    {

        foreach (PrefabInstantiator instantiator in (selectedObject as GameObject).transform.GetComponentsInChildren<PrefabInstantiator>(true))
        {
            Instantiate(instantiator.prefabToInstantiate, instantiator.gameObject);
        }
    }

    private static void Instantiate(GameObject prefab, GameObject parent)
    {
        (PrefabUtility.InstantiatePrefab(prefab) as GameObject).transform.SetParent(parent.transform, false);
>>>>>>> 0219fcf659bd0809c9c53f8ee2778dcc6667295f
    }
}
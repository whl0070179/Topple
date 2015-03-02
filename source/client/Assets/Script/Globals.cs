using UnityEngine;
using System.Collections;

public class Globals : MonoBehaviour
{
    private StateMng m_stateMng = null;
    private EntityMng m_entityMng = null;
    private SceneMng m_sceneMng= null;
    private CameraController m_cameraController = null;
    private TimeMng m_timeMng = null;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    T _CreateLink<T>() where T : Component
    {
        T link = this.GetComponentInChildren<T>();
        if (link == null)
        {
            GameObject linkObj = new GameObject(typeof(T).Name);
            link = linkObj.AddComponent<T>();
            linkObj.transform.parent = this.transform;
        }

        return link;
    }
}

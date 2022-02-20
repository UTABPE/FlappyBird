using System.Collections;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipes;
    PushTransformInfo pushTransformInfo;
    Transform kek;

    void Start(){
        pushTransformInfo = GetComponentInParent<PushTransformInfo>();
        kek = pushTransformInfo.transform;
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner(){
        while (true)
        {   
            yield return new WaitForSeconds(2);
            float rand = Random.Range(-1f, 1f);
            // GameObject newPipes = Instantiate(Pipes, new Vector3(0, rand, 4), Quaternion.identity, kek);
            GameObject newPipes = Instantiate(Pipes, kek, true);
            newPipes.transform.position = new Vector3 (kek.position.x, kek.position.y + rand, kek.position.z);
            Destroy(newPipes, 10);
        }
    }

 
}

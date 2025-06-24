using System.Collections;
using NUnit.Framework;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class MainSceneLoadTest
{
    [UnityTest]
    public IEnumerator MainSceneLoadsWithoutErrors()
    {
        var loadOp = SceneManager.LoadSceneAsync("MainScene");
        while (!loadOp.isDone)
        {
            yield return null;
        }
        Assert.AreEqual("MainScene", SceneManager.GetActiveScene().name);
    }
}

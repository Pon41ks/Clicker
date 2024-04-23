using System;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;



public class JsonToFileStorageService 
{
    /*
    public void Load<T>(string key, Action<T> callBack)
    {
        string path = BuildPath(key);

        using (var fileStream = new StreamReader(path))
        {
            var json = fileStream.ReadToEnd();
           
            var data = JsonConvert.DeserializeObject<T>(json);
            callBack.Invoke(data);
        }
        
    }

    public void Save(string key, object data, Action<bool> Callback = null)
    {
        string path = BuildPath(key);
        
        string json = JsonConvert.SerializeObject(data);
        using (var fileStream = new StreamWriter(path))
        {
            fileStream.Write(json);
        }
        Callback?.Invoke(true);
        Debug.Log(path);
    }

    private string BuildPath(string key){

        return Path.Combine(Application.persistentDataPath, key);
        
    }
    */
}

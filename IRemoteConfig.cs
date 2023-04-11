namespace RemoteConfigs
{
    public interface IRemoteConfig
    {
        bool GetBoolValue(string key);
        float GetFloatValue(string key);
        int GetIntValue(string key);
        string GetStringValue(string key);
    }
}
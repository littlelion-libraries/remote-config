using System;

namespace RemoteConfigs
{
    public class RemoteConfig : IRemoteConfig
    {
        private Func<string, bool> _getBoolValue;
        private Func<string, float> _getFloatValue;
        private Func<string, int> _getIntValue;
        private Func<string, string> _getStringValue;

        public Func<string, bool> GetBoolValue
        {
            set => _getBoolValue = value;
        }

        public Func<string, float> GetFloatValue
        {
            set => _getFloatValue = value;
        }

        public Func<string, int> GetIntValue
        {
            set => _getIntValue = value;
        }

        public Func<string, string> GetStringValue
        {
            set => _getStringValue = value;
        }

        bool IRemoteConfig.GetBoolValue(string key)
        {
            return _getBoolValue(key);
        }

        float IRemoteConfig.GetFloatValue(string key)
        {
            return _getFloatValue(key);
        }

        int IRemoteConfig.GetIntValue(string key)
        {
            return _getIntValue(key);
        }

        string IRemoteConfig.GetStringValue(string key)
        {
            return _getStringValue(key);
        }
    }
}
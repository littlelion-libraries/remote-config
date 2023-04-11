using System.Collections.Generic;

namespace RemoteConfigs
{
    public static class RemoteConfigUtils
    {
        public static void Load(RemoteConfig remoteConfig, IEnumerable<(string, string)> values)
        {
            var boolMap = new Dictionary<string, bool>();
            var floatMap = new Dictionary<string, float>();
            var intMap = new Dictionary<string, int>();
            var stringMap = new Dictionary<string, string>();
            foreach (var (key, value) in values)
            {
                if (bool.TryParse(value, out var b))
                {
                    boolMap.Add(key, b);
                }
                else if (float.TryParse(value, out var f))
                {
                    floatMap.Add(key, f);
                }
                else if (int.TryParse(value, out var i))
                {
                    intMap.Add(key, i);
                }
                else
                {
                    stringMap.Add(key, value);
                }
            }

            remoteConfig.GetBoolValue = key => boolMap[key];
            remoteConfig.GetIntValue = key => intMap[key];
            remoteConfig.GetFloatValue = key => floatMap[key];
            remoteConfig.GetStringValue = key => stringMap[key];
        }
    }
}
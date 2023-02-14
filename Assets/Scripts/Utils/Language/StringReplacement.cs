using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

public class StringReplacement {
    public readonly ReplacementKey keyEnum;
    public readonly string keyString;
    public readonly StringReplace replacementDelegate;

    public delegate string StringReplace(string sourceString, string replacementKey, string replacementValue);

    private StringReplacement(ReplacementKey keyEnum, string keyString, StringReplace replacementDelegate) {
        this.keyEnum = keyEnum;
        this.keyString = "{" + keyString + "}";
        this.replacementDelegate = replacementDelegate;
    }

    public string replace(string sourceString, string replacementValue) {
        return this.replacementDelegate(sourceString, this.keyString, replacementValue);
    }

    public readonly static ReadOnlyCollection<StringReplacement> replacements;

    public static StringReplacement getReplacement(ReplacementKey key) {
        return replacementsMap[key];
    }

    private static Dictionary<ReplacementKey, StringReplacement> replacementsMap;

    static StringReplacement() {
        replacements = new ReadOnlyCollection<StringReplacement>(new List<StringReplacement>() {
                new StringReplacement(ReplacementKey.AMT, "AMT", (s, k, v) => s.Replace(k, v)),
                new StringReplacement(ReplacementKey.DPCT, "DPCT", (s, k, v) => s.Replace(k, v)),
                new StringReplacement(ReplacementKey.EPCT, "EPCT", (s, k, v) => s.Replace(k, v)),
                new StringReplacement(ReplacementKey.PCT_MISC, "PCT_MISC", (s, k, v) => s.Replace(k, v)),
                new StringReplacement(ReplacementKey.SRC, "SRC", (s, k, v) => s.Replace(k, v)),
           });

        replacementsMap = new Dictionary<ReplacementKey, StringReplacement>();
        foreach (StringReplacement replacement in replacements) {
            replacementsMap.Add(replacement.keyEnum, replacement);
        }
    }
}
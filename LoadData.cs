using System;
using System.Collections.Generic;
using UnityEngine;
using UnityBoosts;

namespace Audios
{
    [Serializable]
    public struct LoadData
    {
        public ScriptableObjectPlayClipAction action;
        public ObjectReference<IEnumerable<AudioClip>> clips;
        public AudioSource source;
    }
}
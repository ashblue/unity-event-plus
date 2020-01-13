using UnityEngine;

namespace CleverCrow.Fluid.Utilities.UnityEvents {
    public class EventSerializationExample : MonoBehaviour {
        [System.Serializable]
        public class EventWrapperB : UnityEventPlus<bool> {}

        [System.Serializable]
        public class EventWrapperC : UnityEventPlus<bool, bool> {}

        [System.Serializable]
        public class EventWrapperD : UnityEventPlus<bool, bool, bool> {}

        public UnityEventPlus eventA;
        public EventWrapperB eventB;
        public EventWrapperC eventC;
        public EventWrapperD eventD;
    }
}

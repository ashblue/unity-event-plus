using UnityEngine.Events;

namespace CleverCrow.Fluid.Utilities.UnityEvents {
    [System.Serializable]
    public class UnityEventPlus : UnityEvent, IUnityEvent {
    }

    public class UnityEventPlus<T1> : UnityEvent<T1>, IUnityEvent<T1> {
    }

    public class UnityEventPlus<T1, T2> : UnityEvent<T1, T2>, IUnityEvent<T1, T2> {
    }

    public class UnityEventPlus<T1, T2, T3> : UnityEvent<T1, T2, T3>, IUnityEvent<T1, T2, T3> {
    }
}

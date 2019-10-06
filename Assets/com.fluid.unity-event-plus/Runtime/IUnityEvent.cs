using UnityEngine.Events;

namespace CleverCrow.Fluid.Utilities.UnityEvents {
    public interface IUnityEvent {
        void AddListener (UnityAction call);
        void RemoveListener (UnityAction call);
        void Invoke ();
        void RemoveAllListeners ();
    }

    public interface IUnityEvent<T1> {
        void AddListener (UnityAction<T1> call);
        void RemoveListener (UnityAction<T1> call);
        void Invoke (T1 arg1);
        void RemoveAllListeners ();
    }

    public interface IUnityEvent<T1, T2> {
        void AddListener (UnityAction<T1, T2> call);
        void RemoveListener (UnityAction<T1, T2> call);
        void Invoke (T1 arg1, T2 arg2);
        void RemoveAllListeners ();
    }

    public interface IUnityEvent<T1, T2, T3> {
        void AddListener (UnityAction<T1, T2, T3> call);
        void RemoveListener (UnityAction<T1, T2, T3> call);
        void Invoke (T1 arg1, T2 arg2, T3 arg3);
        void RemoveAllListeners ();
    }
}

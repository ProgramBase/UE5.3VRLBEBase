using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Blutility
{
	public class FAsyncEditorWaitForGameWorldEvent : FMulticastDelegate<Action<UWorld>>
	{
		public FAsyncEditorWaitForGameWorldEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FAsyncEditorWaitForGameWorldEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UWorld World)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = World?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}

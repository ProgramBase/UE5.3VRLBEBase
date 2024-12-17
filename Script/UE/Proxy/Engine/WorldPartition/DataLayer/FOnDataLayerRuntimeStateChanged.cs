using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnDataLayerRuntimeStateChanged : FMulticastDelegate<Action<UDataLayerInstance, EDataLayerRuntimeState>>
	{
		public FOnDataLayerRuntimeStateChanged() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnDataLayerRuntimeStateChanged() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UDataLayerInstance DataLayer, EDataLayerRuntimeState State)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = DataLayer?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)State;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}

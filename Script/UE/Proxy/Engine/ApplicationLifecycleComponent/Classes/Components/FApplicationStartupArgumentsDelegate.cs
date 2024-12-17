using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine.ApplicationLifecycleComponent
{
	public class FApplicationStartupArgumentsDelegate : FMulticastDelegate<Action<TArray<FString>>>
	{
		public FApplicationStartupArgumentsDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FApplicationStartupArgumentsDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(TArray<FString> StartupArguments)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = StartupArguments?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}

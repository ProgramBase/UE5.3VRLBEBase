using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine.PlatformGameInstance
{
	public class FPlatformStartupArgumentsDelegate : FMulticastDelegate<Action<TArray<FString>>>
	{
		public FPlatformStartupArgumentsDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FPlatformStartupArgumentsDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

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

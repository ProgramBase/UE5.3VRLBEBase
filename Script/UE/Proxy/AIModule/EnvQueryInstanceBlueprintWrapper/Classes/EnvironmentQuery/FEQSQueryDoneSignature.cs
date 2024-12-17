using System;
using Script.CoreUObject;
using Script.Library;
using Script.AIModule;

namespace Script.AIModule.EnvQueryInstanceBlueprintWrapper
{
	public class FEQSQueryDoneSignature : FMulticastDelegate<Action<UEnvQueryInstanceBlueprintWrapper, EEnvQueryStatus>>
	{
		public FEQSQueryDoneSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FEQSQueryDoneSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UEnvQueryInstanceBlueprintWrapper QueryInstance, EEnvQueryStatus QueryStatus)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = QueryInstance?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)QueryStatus;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}

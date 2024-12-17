using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AIModule.PawnSensingComponent
{
	public class FHearNoiseDelegate : FMulticastDelegate<Action<APawn, FVector, float>>
	{
		public FHearNoiseDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FHearNoiseDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(APawn Instigator, FVector Location, float Volume)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Instigator?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Volume;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}

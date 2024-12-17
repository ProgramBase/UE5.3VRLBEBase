using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnSystemFinished : FMulticastDelegate<Action<UParticleSystemComponent>>
	{
		public FOnSystemFinished() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnSystemFinished() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UParticleSystemComponent PSystem)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PSystem?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}

using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FInstigatedAnyDamageSignature : FMulticastDelegate<Action<float, UDamageType, AActor, AActor>>
	{
		public FInstigatedAnyDamageSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FInstigatedAnyDamageSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(float Damage, UDamageType DamageType, AActor DamagedActor, AActor DamageCauser)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(float*)(__InBuffer) = Damage;

				*(nint*)(__InBuffer + 4) = DamageType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 12) = DamagedActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = DamageCauser?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}

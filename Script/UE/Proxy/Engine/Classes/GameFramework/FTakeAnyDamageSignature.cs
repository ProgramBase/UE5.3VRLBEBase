using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FTakeAnyDamageSignature : FMulticastDelegate<Action<AActor, float, UDamageType, AController, AActor>>
	{
		public FTakeAnyDamageSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FTakeAnyDamageSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(AActor DamagedActor, float Damage, UDamageType DamageType, AController InstigatedBy, AActor DamageCauser)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = DamagedActor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Damage;

				*(nint*)(__InBuffer + 12) = DamageType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = InstigatedBy?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 28) = DamageCauser?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}

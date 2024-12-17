using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FTakeRadialDamageSignature : FMulticastDelegate<Action<AActor, float, UDamageType, FVector, FHitResult, AController, AActor>>
	{
		public FTakeRadialDamageSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FTakeRadialDamageSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(AActor DamagedActor, float Damage, UDamageType DamageType, FVector Origin, FHitResult HitInfo, AController InstigatedBy, AActor DamageCauser)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[52];

				*(nint*)(__InBuffer) = DamagedActor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Damage;

				*(nint*)(__InBuffer + 12) = DamageType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = Origin?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 28) = HitInfo?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 36) = InstigatedBy?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 44) = DamageCauser?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}

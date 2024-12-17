using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FTakePointDamageSignature : FMulticastDelegate<Action<AActor, float, AController, FVector, UPrimitiveComponent, FName, FVector, UDamageType, AActor>>
	{
		public FTakePointDamageSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FTakePointDamageSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(AActor DamagedActor, float Damage, AController InstigatedBy, FVector HitLocation, UPrimitiveComponent FHitComponent, FName BoneName, FVector ShotFromDirection, UDamageType DamageType, AActor DamageCauser)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[68];

				*(nint*)(__InBuffer) = DamagedActor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Damage;

				*(nint*)(__InBuffer + 12) = InstigatedBy?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = HitLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 28) = FHitComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 36) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 44) = ShotFromDirection?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 52) = DamageType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 60) = DamageCauser?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}

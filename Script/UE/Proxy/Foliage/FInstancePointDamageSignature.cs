using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Foliage
{
	public class FInstancePointDamageSignature : FMulticastDelegate<Action<int, float, AController, FVector, FVector, UDamageType, AActor>>
	{
		public FInstancePointDamageSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FInstancePointDamageSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(int InstanceIndex, float Damage, AController InstigatedBy, FVector HitLocation, FVector ShotFromDirection, UDamageType DamageType, AActor DamageCauser)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[48];

				*(int*)(__InBuffer) = InstanceIndex;

				*(float*)(__InBuffer + 4) = Damage;

				*(nint*)(__InBuffer + 8) = InstigatedBy?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = HitLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ShotFromDirection?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = DamageType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = DamageCauser?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}

using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Foliage
{
	public class FInstanceRadialDamageSignature : FMulticastDelegate<Action<TArray<int>, TArray<float>, AController, FVector, float, UDamageType, AActor>>
	{
		public FInstanceRadialDamageSignature() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FInstanceRadialDamageSignature() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(TArray<int> Instances, TArray<float> Damages, AController InstigatedBy, FVector Origin, float MaxRadius, UDamageType DamageType, AActor DamageCauser)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[52];

				*(nint*)(__InBuffer) = Instances?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Damages?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InstigatedBy?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Origin?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 32) = MaxRadius;

				*(nint*)(__InBuffer + 36) = DamageType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 44) = DamageCauser?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}

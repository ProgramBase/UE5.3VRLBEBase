using System;
using Script.CoreUObject;
using Script.Library;
using Script.Constraints;

namespace Script.Constraints.ConstraintsManager
{
	public class FOnConstraintAdded : FMulticastDelegate<Action<UConstraintsManager, UTickableConstraint>>
	{
		public FOnConstraintAdded() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnConstraintAdded() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UConstraintsManager Mananger, UTickableConstraint Constraint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Mananger?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Constraint?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}

using System;
using Script.CoreUObject;
using Script.Library;
using Script.Constraints;

namespace Script.Constraints.ConstraintsManager
{
	public class FOnConstraintRemoved : FMulticastDelegate<Action<UConstraintsManager, UTickableConstraint, bool>>
	{
		public FOnConstraintRemoved() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnConstraintRemoved() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UConstraintsManager Mananger, UTickableConstraint Constraint, bool bDoNotCompensate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Mananger?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Constraint?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bDoNotCompensate;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}

using System;
using Script.CoreUObject;
using Script.Library;
using Script.ControlRig;

namespace Script.ControlRig.ControlRig
{
	public class FOnControlSelectedBP : FMulticastDelegate<Action<UControlRig, FRigControlElement, bool>>
	{
		public FOnControlSelectedBP() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnControlSelectedBP() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UControlRig Rig, FRigControlElement Control, bool bSelected)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Rig?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Control?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bSelected;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}

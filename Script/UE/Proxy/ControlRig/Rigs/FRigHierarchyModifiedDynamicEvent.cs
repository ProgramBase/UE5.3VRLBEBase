using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	public class FRigHierarchyModifiedDynamicEvent : FMulticastDelegate<Action<ERigHierarchyNotification, URigHierarchy, FRigElementKey>>
	{
		public FRigHierarchyModifiedDynamicEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FRigHierarchyModifiedDynamicEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(ERigHierarchyNotification NotifType, URigHierarchy Hierarchy, FRigElementKey Subject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(byte*)(__InBuffer) = (byte)NotifType;

				*(nint*)(__InBuffer + 1) = Hierarchy?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 9) = Subject?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}

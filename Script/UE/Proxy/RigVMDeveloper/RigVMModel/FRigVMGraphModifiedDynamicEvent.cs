using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.RigVMDeveloper
{
	public class FRigVMGraphModifiedDynamicEvent : FMulticastDelegate<Action<ERigVMGraphNotifType, URigVMGraph, UObject>>
	{
		public FRigVMGraphModifiedDynamicEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FRigVMGraphModifiedDynamicEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(ERigVMGraphNotifType NotifType, URigVMGraph Graph, UObject Subject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(byte*)(__InBuffer) = (byte)NotifType;

				*(nint*)(__InBuffer + 1) = Graph?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 9) = Subject?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}

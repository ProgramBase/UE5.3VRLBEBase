using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryFramework
{
	public class FOnDynamicMeshModifiedBP : FMulticastDelegate<Action<UDynamicMesh>>
	{
		public FOnDynamicMeshModifiedBP() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnDynamicMeshModifiedBP() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UDynamicMesh Mesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}

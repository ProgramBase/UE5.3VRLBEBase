using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.MRMesh.MockDataMeshTrackerComponent
{
	public class FOnMockDataMeshTrackerUpdated : FMulticastDelegate<Action<int, TArray<FVector>, TArray<int>, TArray<FVector>, TArray<float>>>
	{
		public FOnMockDataMeshTrackerUpdated() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnMockDataMeshTrackerUpdated() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(int Index, TArray<FVector> Vertices, TArray<int> Triangles, TArray<FVector> Normals, TArray<float> Confidence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(int*)(__InBuffer) = Index;

				*(nint*)(__InBuffer + 4) = Vertices?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 12) = Triangles?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = Normals?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 28) = Confidence?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}

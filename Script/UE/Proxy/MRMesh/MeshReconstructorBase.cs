using Script.CoreUObject;
using Script.Library;

namespace Script.MRMesh
{
	[PathName("/Script/MRMesh.MeshReconstructorBase")]
	public partial class UMeshReconstructorBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MRMesh.MeshReconstructorBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void StopReconstruction()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __StopReconstruction);
			}
		}

		public virtual void StartReconstruction()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __StartReconstruction);
			}
		}

		public virtual void PauseReconstruction()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __PauseReconstruction);
			}
		}

		public virtual bool IsReconstructionStarted()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsReconstructionStarted, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsReconstructionPaused()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsReconstructionPaused, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void DisconnectMRMesh()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DisconnectMRMesh);
			}
		}

		public virtual void ConnectMRMesh(UMRMeshComponent Mesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ConnectMRMesh, __InBuffer);
			}
		}

		private static uint __StopReconstruction = 0;

		private static uint __StartReconstruction = 0;

		private static uint __PauseReconstruction = 0;

		private static uint __IsReconstructionStarted = 0;

		private static uint __IsReconstructionPaused = 0;

		private static uint __DisconnectMRMesh = 0;

		private static uint __ConnectMRMesh = 0;
	}
}
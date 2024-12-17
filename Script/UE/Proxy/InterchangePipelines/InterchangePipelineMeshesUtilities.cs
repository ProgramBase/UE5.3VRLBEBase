using Script.CoreUObject;
using Script.Library;
using Script.InterchangeCore;

namespace Script.InterchangePipelines
{
	[PathName("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities")]
	public partial class UInterchangePipelineMeshesUtilities : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangePipelines.InterchangePipelineMeshesUtilities");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetContext(FInterchangePipelineMeshesUtilitiesContext Context)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetContext, __InBuffer);
			}
		}

		public virtual bool IsValidMeshInstanceUid(FString MeshInstanceUid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MeshInstanceUid?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsValidMeshInstanceUid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsValidMeshGeometryUid(FString MeshGeometryUid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MeshGeometryUid?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsValidMeshGeometryUid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FString GetMeshInstanceSkeletonRootUid(FString MeshInstanceUid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MeshInstanceUid?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetMeshInstanceSkeletonRootUid, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual FInterchangeMeshInstance GetMeshInstanceByUid(FString MeshInstanceUid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MeshInstanceUid?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetMeshInstanceByUid, __InBuffer, __ReturnBuffer);

				return *(FInterchangeMeshInstance*)__ReturnBuffer;
			}
		}

		public virtual FString GetMeshGeometrySkeletonRootUid(FString MeshGeometryUid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MeshGeometryUid?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetMeshGeometrySkeletonRootUid, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual FInterchangeMeshGeometry GetMeshGeometryByUid(FString MeshGeometryUid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MeshGeometryUid?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetMeshGeometryByUid, __InBuffer, __ReturnBuffer);

				return *(FInterchangeMeshGeometry*)__ReturnBuffer;
			}
		}

		public virtual void GetAllStaticMeshInstance(ref TArray<FString> MeshInstanceUids)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MeshInstanceUids?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetAllStaticMeshInstance, __InBuffer, __OutBuffer);

				MeshInstanceUids = *(TArray<FString>*)(__OutBuffer);

			}
		}

		public virtual void GetAllStaticMeshGeometry(ref TArray<FString> MeshGeometryUids)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MeshGeometryUids?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetAllStaticMeshGeometry, __InBuffer, __OutBuffer);

				MeshGeometryUids = *(TArray<FString>*)(__OutBuffer);

			}
		}

		public virtual void GetAllSkinnedMeshInstance(ref TArray<FString> MeshInstanceUids)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MeshInstanceUids?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetAllSkinnedMeshInstance, __InBuffer, __OutBuffer);

				MeshInstanceUids = *(TArray<FString>*)(__OutBuffer);

			}
		}

		public virtual void GetAllSkinnedMeshGeometry(ref TArray<FString> MeshGeometryUids)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MeshGeometryUids?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetAllSkinnedMeshGeometry, __InBuffer, __OutBuffer);

				MeshGeometryUids = *(TArray<FString>*)(__OutBuffer);

			}
		}

		public virtual void GetAllMeshInstanceUidsUsingMeshGeometryUid(FString MeshGeometryUid, ref TArray<FString> MeshInstanceUids)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MeshGeometryUid?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MeshInstanceUids?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetAllMeshInstanceUidsUsingMeshGeometryUid, __InBuffer, __OutBuffer);

				MeshInstanceUids = *(TArray<FString>*)(__OutBuffer);

			}
		}

		public virtual void GetAllMeshInstanceUids(ref TArray<FString> MeshInstanceUids)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MeshInstanceUids?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetAllMeshInstanceUids, __InBuffer, __OutBuffer);

				MeshInstanceUids = *(TArray<FString>*)(__OutBuffer);

			}
		}

		public virtual void GetAllMeshGeometryNotInstanced(ref TArray<FString> MeshGeometryUids)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MeshGeometryUids?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetAllMeshGeometryNotInstanced, __InBuffer, __OutBuffer);

				MeshGeometryUids = *(TArray<FString>*)(__OutBuffer);

			}
		}

		public virtual void GetAllMeshGeometry(ref TArray<FString> MeshGeometryUids)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MeshGeometryUids?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetAllMeshGeometry, __InBuffer, __OutBuffer);

				MeshGeometryUids = *(TArray<FString>*)(__OutBuffer);

			}
		}

		public static UInterchangePipelineMeshesUtilities CreateInterchangePipelineMeshesUtilities(UInterchangeBaseNodeContainer BaseNodeContainer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BaseNodeContainer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateInterchangePipelineMeshesUtilities, __InBuffer, __ReturnBuffer);

				return *(UInterchangePipelineMeshesUtilities*)__ReturnBuffer;
			}
		}

		private static uint __SetContext = 0;

		private static uint __IsValidMeshInstanceUid = 0;

		private static uint __IsValidMeshGeometryUid = 0;

		private static uint __GetMeshInstanceSkeletonRootUid = 0;

		private static uint __GetMeshInstanceByUid = 0;

		private static uint __GetMeshGeometrySkeletonRootUid = 0;

		private static uint __GetMeshGeometryByUid = 0;

		private static uint __GetAllStaticMeshInstance = 0;

		private static uint __GetAllStaticMeshGeometry = 0;

		private static uint __GetAllSkinnedMeshInstance = 0;

		private static uint __GetAllSkinnedMeshGeometry = 0;

		private static uint __GetAllMeshInstanceUidsUsingMeshGeometryUid = 0;

		private static uint __GetAllMeshInstanceUids = 0;

		private static uint __GetAllMeshGeometryNotInstanced = 0;

		private static uint __GetAllMeshGeometry = 0;

		private static uint __CreateInterchangePipelineMeshesUtilities = 0;
	}
}
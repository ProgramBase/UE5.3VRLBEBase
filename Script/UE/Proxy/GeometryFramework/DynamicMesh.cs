using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryFramework
{
	[PathName("/Script/GeometryFramework.DynamicMesh")]
	public partial class UDynamicMesh : UObject, IStaticClass, IMeshVertexCommandChangeTarget, IMeshCommandChangeTarget, IMeshReplacementCommandChangeTarget
	{
		public FOnDynamicMeshModifiedBP MeshModifiedBPEvent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MeshModifiedBPEvent, __ReturnBuffer);

					return *(FOnDynamicMeshModifiedBP*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MeshModifiedBPEvent, __InBuffer);
				}
			}
		}

		public UDynamicMeshGenerator MeshGenerator
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MeshGenerator, __ReturnBuffer);

					return *(UDynamicMeshGenerator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MeshGenerator, __InBuffer);
				}
			}
		}

		public bool bEnableMeshGenerator
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableMeshGenerator, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableMeshGenerator, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryFramework.DynamicMesh");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		public virtual UDynamicMesh ResetToCube()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __ResetToCube, __ReturnBuffer);

				return *(UDynamicMesh*)__ReturnBuffer;
			}
		}

		public virtual UDynamicMesh Reset()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __Reset, __ReturnBuffer);

				return *(UDynamicMesh*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if the mesh has no triangles
		/// </returns>
		public virtual bool IsEmpty()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsEmpty, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// number of triangles in the mesh
		/// </returns>
		public virtual int GetTriangleCount()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetTriangleCount, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __MeshModifiedBPEvent = 0;

		private static uint __MeshGenerator = 0;

		private static uint __bEnableMeshGenerator = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __ResetToCube = 0;

		private static uint __Reset = 0;

		private static uint __IsEmpty = 0;

		private static uint __GetTriangleCount = 0;
	}
}
using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.GeometryFramework
{
	[PathName("/Script/GeometryFramework.DynamicMeshActor")]
	public partial class ADynamicMeshActor : AActor, IStaticClass
	{
		public UDynamicMeshComponent DynamicMeshComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DynamicMeshComponent, __ReturnBuffer);

					return *(UDynamicMeshComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DynamicMeshComponent, __InBuffer);
				}
			}
		}

		public bool bEnableComputeMeshPool
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableComputeMeshPool, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableComputeMeshPool, __InBuffer);
				}
			}
		}

		public UDynamicMeshPool DynamicMeshPool
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DynamicMeshPool, __ReturnBuffer);

					return *(UDynamicMeshPool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DynamicMeshPool, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryFramework.DynamicMeshActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool ReleaseComputeMesh(UDynamicMesh Mesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ReleaseComputeMesh, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void ReleaseAllComputeMeshes()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ReleaseAllComputeMeshes);
			}
		}

		public virtual UDynamicMeshComponent GetDynamicMeshComponent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDynamicMeshComponent, __ReturnBuffer);

				return *(UDynamicMeshComponent*)__ReturnBuffer;
			}
		}

		public virtual UDynamicMeshPool GetComputeMeshPool()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetComputeMeshPool, __ReturnBuffer);

				return *(UDynamicMeshPool*)__ReturnBuffer;
			}
		}

		public virtual void FreeAllComputeMeshes()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __FreeAllComputeMeshes);
			}
		}

		public virtual UDynamicMesh AllocateComputeMesh()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __AllocateComputeMesh, __ReturnBuffer);

				return *(UDynamicMesh*)__ReturnBuffer;
			}
		}

		private static uint __DynamicMeshComponent = 0;

		private static uint __bEnableComputeMeshPool = 0;

		private static uint __DynamicMeshPool = 0;

		private static uint __ReleaseComputeMesh = 0;

		private static uint __ReleaseAllComputeMeshes = 0;

		private static uint __GetDynamicMeshComponent = 0;

		private static uint __GetComputeMeshPool = 0;

		private static uint __FreeAllComputeMeshes = 0;

		private static uint __AllocateComputeMesh = 0;
	}
}
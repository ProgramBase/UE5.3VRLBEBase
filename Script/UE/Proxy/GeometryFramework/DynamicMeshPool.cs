using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryFramework
{
	[PathName("/Script/GeometryFramework.DynamicMeshPool")]
	public partial class UDynamicMeshPool : UObject, IStaticClass
	{
		public TArray<UDynamicMesh> CachedMeshes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedMeshes, __ReturnBuffer);

					return *(TArray<UDynamicMesh>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedMeshes, __InBuffer);
				}
			}
		}

		public TArray<UDynamicMesh> AllCreatedMeshes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AllCreatedMeshes, __ReturnBuffer);

					return *(TArray<UDynamicMesh>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AllCreatedMeshes, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryFramework.DynamicMeshPool");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ReturnMesh(UDynamicMesh Mesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Mesh?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ReturnMesh, __InBuffer);
			}
		}

		public virtual void ReturnAllMeshes()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ReturnAllMeshes);
			}
		}

		/// <returns>
		/// an available UDynamicMesh from the pool (possibly allocating a new mesh) */
		/// </returns>
		public virtual UDynamicMesh RequestMesh()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __RequestMesh, __ReturnBuffer);

				return *(UDynamicMesh*)__ReturnBuffer;
			}
		}

		public virtual void FreeAllMeshes()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __FreeAllMeshes);
			}
		}

		private static uint __CachedMeshes = 0;

		private static uint __AllCreatedMeshes = 0;

		private static uint __ReturnMesh = 0;

		private static uint __ReturnAllMeshes = 0;

		private static uint __RequestMesh = 0;

		private static uint __FreeAllMeshes = 0;
	}
}
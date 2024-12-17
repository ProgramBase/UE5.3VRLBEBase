using Script.CoreUObject;
using Script.Library;

namespace Script.MeshDescription
{
	[PathName("/Script/MeshDescription.MeshDescriptionBaseBulkData")]
	public partial class UMeshDescriptionBaseBulkData : UObject, IStaticClass
	{
		public UMeshDescriptionBase PreallocatedMeshDescription
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreallocatedMeshDescription, __ReturnBuffer);

					return *(UMeshDescriptionBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreallocatedMeshDescription, __InBuffer);
				}
			}
		}

		public UMeshDescriptionBase MeshDescription
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MeshDescription, __ReturnBuffer);

					return *(UMeshDescriptionBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MeshDescription, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshDescription.MeshDescriptionBaseBulkData");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PreallocatedMeshDescription = 0;

		private static uint __MeshDescription = 0;
	}
}
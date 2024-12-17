using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.WorldPartitionHLODUtilities
{
	[PathName("/Script/WorldPartitionHLODUtilities.HLODBuilderMeshMergeSettings")]
	public partial class UHLODBuilderMeshMergeSettings : UHLODBuilderSettings, IStaticClass
	{
		public FMeshMergingSettings MeshMergeSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MeshMergeSettings, __ReturnBuffer);

					return *(FMeshMergingSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MeshMergeSettings, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<UMaterialInterface> HLODMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HLODMaterial, __ReturnBuffer);

					return *(TSoftObjectPtr<UMaterialInterface>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HLODMaterial, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/WorldPartitionHLODUtilities.HLODBuilderMeshMergeSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __MeshMergeSettings = 0;

		private static uint __HLODMaterial = 0;
	}
}
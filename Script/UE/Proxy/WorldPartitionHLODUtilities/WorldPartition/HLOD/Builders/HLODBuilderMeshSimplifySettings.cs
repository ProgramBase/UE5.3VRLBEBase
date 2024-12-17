using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.WorldPartitionHLODUtilities
{
	[PathName("/Script/WorldPartitionHLODUtilities.HLODBuilderMeshSimplifySettings")]
	public partial class UHLODBuilderMeshSimplifySettings : UHLODBuilderSettings, IStaticClass
	{
		public FMeshProxySettings MeshSimplifySettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MeshSimplifySettings, __ReturnBuffer);

					return *(FMeshProxySettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MeshSimplifySettings, __InBuffer);
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/WorldPartitionHLODUtilities.HLODBuilderMeshSimplifySettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __MeshSimplifySettings = 0;

		private static uint __HLODMaterial = 0;
	}
}
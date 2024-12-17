using Script.CoreUObject;
using Script.EditorConfig;
using Script.Library;

namespace Script.ContentBrowser
{
	[PathName("/Script/ContentBrowser.AssetViewConfig")]
	public partial class UAssetViewConfig : UEditorConfigBase, IStaticClass
	{
		public TMap<FName, FAssetViewInstanceConfig> Instances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Instances, __ReturnBuffer);

					return *(TMap<FName, FAssetViewInstanceConfig>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Instances, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ContentBrowser.AssetViewConfig");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Instances = 0;
	}
}
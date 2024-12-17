using Script.CoreUObject;
using Script.EditorConfig;
using Script.Library;

namespace Script.SceneOutliner
{
	[PathName("/Script/SceneOutliner.OutlinerConfig")]
	public partial class UOutlinerConfig : UEditorConfigBase, IStaticClass
	{
		public TMap<FName, FSceneOutlinerConfig> Outliners
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Outliners, __ReturnBuffer);

					return *(TMap<FName, FSceneOutlinerConfig>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Outliners, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SceneOutliner.OutlinerConfig");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Outliners = 0;
	}
}
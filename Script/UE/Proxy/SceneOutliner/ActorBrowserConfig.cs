using Script.CoreUObject;
using Script.EditorConfig;
using Script.Library;

namespace Script.SceneOutliner
{
	[PathName("/Script/SceneOutliner.ActorBrowserConfig")]
	public partial class UActorBrowserConfig : UEditorConfigBase, IStaticClass
	{
		public TMap<FName, FActorBrowsingModeConfig> ActorBrowsers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActorBrowsers, __ReturnBuffer);

					return *(TMap<FName, FActorBrowsingModeConfig>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActorBrowsers, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SceneOutliner.ActorBrowserConfig");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ActorBrowsers = 0;
	}
}
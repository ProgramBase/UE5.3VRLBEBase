using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherCore
{
	[PathName("/Script/HotPatcherCore.HotGlobalShaderCommandlet")]
	public partial class UHotGlobalShaderCommandlet : UHotPatcherCommandletBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HotPatcherCore.HotGlobalShaderCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
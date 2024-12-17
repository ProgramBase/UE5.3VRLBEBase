using Script.CoreUObject;
using Script.ToolMenus;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.CommonResolutionMenuContext")]
	public partial class UCommonResolutionMenuContext : UToolMenuContextBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.CommonResolutionMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
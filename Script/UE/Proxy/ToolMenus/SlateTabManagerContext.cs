using Script.CoreUObject;
using Script.Library;

namespace Script.ToolMenus
{
	[PathName("/Script/ToolMenus.SlateTabManagerContext")]
	public partial class USlateTabManagerContext : UToolMenuContextBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ToolMenus.SlateTabManagerContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
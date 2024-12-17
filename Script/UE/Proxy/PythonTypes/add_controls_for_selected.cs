using Script.CoreUObject;
using Script.ToolMenus;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/add_controls_for_selected.add_controls_for_selected")]
	public partial class add_controls_for_selected : UToolMenuEntryScript, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/add_controls_for_selected.add_controls_for_selected");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
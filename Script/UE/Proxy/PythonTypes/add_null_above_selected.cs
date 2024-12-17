using Script.CoreUObject;
using Script.ToolMenus;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/add_null_above_selected.add_null_above_selected")]
	public partial class add_null_above_selected : UToolMenuEntryScript, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/add_null_above_selected.add_null_above_selected");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
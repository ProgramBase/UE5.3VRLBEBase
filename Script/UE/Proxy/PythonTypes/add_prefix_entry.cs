using Script.CoreUObject;
using Script.ToolMenus;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/add_prefix_entry.add_prefix_entry")]
	public partial class add_prefix_entry : UToolMenuEntryScript, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/add_prefix_entry.add_prefix_entry");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
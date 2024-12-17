using Script.CoreUObject;
using Script.ToolMenus;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/add_suffix_entry.add_suffix_entry")]
	public partial class add_suffix_entry : UToolMenuEntryScript, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/add_suffix_entry.add_suffix_entry");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
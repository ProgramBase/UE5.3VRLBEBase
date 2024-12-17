using Script.CoreUObject;
using Script.ToolMenus;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/search_replace_entry.search_replace_entry")]
	public partial class search_replace_entry : UToolMenuEntryScript, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/search_replace_entry.search_replace_entry");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
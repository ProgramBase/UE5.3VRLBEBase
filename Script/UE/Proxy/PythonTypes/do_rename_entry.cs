using Script.CoreUObject;
using Script.ToolMenus;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/do_rename_entry.do_rename_entry")]
	public partial class do_rename_entry : UToolMenuEntryScript, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/do_rename_entry.do_rename_entry");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
using Script.CoreUObject;
using Script.ToolMenus;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/align_translation_all.align_translation_all")]
	public partial class align_translation_all : UToolMenuEntryScript, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/align_translation_all.align_translation_all");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
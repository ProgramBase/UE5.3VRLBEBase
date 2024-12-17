using Script.CoreUObject;
using Script.ToolMenus;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/align_translation_y.align_translation_y")]
	public partial class align_translation_y : UToolMenuEntryScript, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/align_translation_y.align_translation_y");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
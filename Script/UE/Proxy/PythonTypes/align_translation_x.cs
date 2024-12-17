using Script.CoreUObject;
using Script.ToolMenus;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/align_translation_x.align_translation_x")]
	public partial class align_translation_x : UToolMenuEntryScript, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/align_translation_x.align_translation_x");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
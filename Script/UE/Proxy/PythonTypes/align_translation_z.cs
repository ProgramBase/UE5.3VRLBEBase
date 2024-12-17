using Script.CoreUObject;
using Script.ToolMenus;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/align_translation_z.align_translation_z")]
	public partial class align_translation_z : UToolMenuEntryScript, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/align_translation_z.align_translation_z");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
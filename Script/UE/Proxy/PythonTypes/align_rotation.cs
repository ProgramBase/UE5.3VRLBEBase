using Script.CoreUObject;
using Script.ToolMenus;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Engine/align_rotation.align_rotation")]
	public partial class align_rotation : UToolMenuEntryScript, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Engine/align_rotation.align_rotation");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
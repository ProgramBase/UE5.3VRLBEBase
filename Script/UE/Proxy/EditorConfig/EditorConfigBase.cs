using Script.CoreUObject;
using Script.Library;

namespace Script.EditorConfig
{
	[PathName("/Script/EditorConfig.EditorConfigBase")]
	public partial class UEditorConfigBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorConfig.EditorConfigBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
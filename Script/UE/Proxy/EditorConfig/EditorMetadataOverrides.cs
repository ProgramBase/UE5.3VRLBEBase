using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;

namespace Script.EditorConfig
{
	[PathName("/Script/EditorConfig.EditorMetadataOverrides")]
	public partial class UEditorMetadataOverrides : UEditorSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorConfig.EditorMetadataOverrides");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
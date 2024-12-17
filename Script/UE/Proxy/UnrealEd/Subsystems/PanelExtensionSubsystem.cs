using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.PanelExtensionSubsystem")]
	public partial class UPanelExtensionSubsystem : UEditorSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.PanelExtensionSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
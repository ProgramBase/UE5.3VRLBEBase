using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.BrushEditingSubsystem")]
	public partial class UBrushEditingSubsystem : UEditorSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.BrushEditingSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
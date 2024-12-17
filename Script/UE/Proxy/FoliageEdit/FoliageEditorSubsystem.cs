using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;

namespace Script.FoliageEdit
{
	[PathName("/Script/FoliageEdit.FoliageEditorSubsystem")]
	public partial class UFoliageEditorSubsystem : UEditorSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FoliageEdit.FoliageEditorSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
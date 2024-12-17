using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.LevelEditorDragDropHandler")]
	public partial class ULevelEditorDragDropHandler : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.LevelEditorDragDropHandler");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
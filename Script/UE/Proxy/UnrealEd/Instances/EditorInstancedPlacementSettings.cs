using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EditorInstancedPlacementSettings")]
	public partial class UEditorInstancedPlacementSettings : UInstancedPlacemenClientSettings, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.EditorInstancedPlacementSettings");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
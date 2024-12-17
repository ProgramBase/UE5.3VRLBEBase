using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EditorBrushBuilder")]
	public partial class UEditorBrushBuilder : UBrushBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.EditorBrushBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
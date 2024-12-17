using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EditorAnimBaseObj")]
	public partial class UEditorAnimBaseObj : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.EditorAnimBaseObj");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
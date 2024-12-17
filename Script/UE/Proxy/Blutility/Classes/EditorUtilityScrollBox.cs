using Script.CoreUObject;
using Script.UMG;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityScrollBox")]
	public partial class UEditorUtilityScrollBox : UScrollBox, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityScrollBox");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
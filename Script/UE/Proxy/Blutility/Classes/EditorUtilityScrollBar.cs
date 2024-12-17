using Script.CoreUObject;
using Script.UMG;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityScrollBar")]
	public partial class UEditorUtilityScrollBar : UScrollBar, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityScrollBar");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
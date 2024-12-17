using Script.CoreUObject;
using Script.UMG;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilitySlider")]
	public partial class UEditorUtilitySlider : USlider, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilitySlider");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
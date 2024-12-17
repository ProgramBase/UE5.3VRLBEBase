using Script.CoreUObject;
using Script.UMG;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityInputKeySelector")]
	public partial class UEditorUtilityInputKeySelector : UInputKeySelector, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityInputKeySelector");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
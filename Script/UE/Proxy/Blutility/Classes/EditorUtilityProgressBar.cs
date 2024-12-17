using Script.CoreUObject;
using Script.UMG;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityProgressBar")]
	public partial class UEditorUtilityProgressBar : UProgressBar, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityProgressBar");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
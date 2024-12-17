using Script.CoreUObject;
using Script.UMG;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityThrobber")]
	public partial class UEditorUtilityThrobber : UThrobber, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityThrobber");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
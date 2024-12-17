using Script.CoreUObject;
using Script.UMG;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityCircularThrobber")]
	public partial class UEditorUtilityCircularThrobber : UCircularThrobber, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityCircularThrobber");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
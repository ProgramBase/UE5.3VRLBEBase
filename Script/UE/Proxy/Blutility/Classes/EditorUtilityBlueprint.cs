using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityBlueprint")]
	public partial class UEditorUtilityBlueprint : UBlueprint, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityBlueprint");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
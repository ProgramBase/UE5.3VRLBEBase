using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityActorComponent")]
	public partial class UEditorUtilityActorComponent : UActorComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityActorComponent");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
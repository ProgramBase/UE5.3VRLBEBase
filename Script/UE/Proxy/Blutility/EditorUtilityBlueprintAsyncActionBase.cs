using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityBlueprintAsyncActionBase")]
	public partial class UEditorUtilityBlueprintAsyncActionBase : UBlueprintAsyncActionBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityBlueprintAsyncActionBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
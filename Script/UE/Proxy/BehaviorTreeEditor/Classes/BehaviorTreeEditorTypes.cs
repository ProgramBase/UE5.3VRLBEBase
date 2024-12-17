using Script.CoreUObject;
using Script.Library;

namespace Script.BehaviorTreeEditor
{
	[PathName("/Script/BehaviorTreeEditor.BehaviorTreeEditorTypes")]
	public partial class UBehaviorTreeEditorTypes : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BehaviorTreeEditor.BehaviorTreeEditorTypes");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
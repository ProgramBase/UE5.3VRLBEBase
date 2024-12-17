using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.DataflowEditor
{
	[PathName("/Script/DataflowEditor.DataflowSchema")]
	public partial class UDataflowSchema : UEdGraphSchema, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DataflowEditor.DataflowSchema");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
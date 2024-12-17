using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_SetFieldsInStruct")]
	public partial class UK2Node_SetFieldsInStruct : UK2Node_MakeStruct, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_SetFieldsInStruct");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
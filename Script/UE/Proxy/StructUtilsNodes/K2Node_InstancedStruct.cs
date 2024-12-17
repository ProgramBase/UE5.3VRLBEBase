using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.Library;

namespace Script.StructUtilsNodes
{
	[PathName("/Script/StructUtilsNodes.K2Node_InstancedStruct")]
	public partial class UK2Node_InstancedStruct : UK2Node_CallFunction, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/StructUtilsNodes.K2Node_InstancedStruct");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
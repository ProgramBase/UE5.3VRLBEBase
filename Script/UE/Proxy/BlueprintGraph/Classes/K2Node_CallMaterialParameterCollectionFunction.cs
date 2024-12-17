using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_CallMaterialParameterCollectionFunction")]
	public partial class UK2Node_CallMaterialParameterCollectionFunction : UK2Node_CallFunction, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_CallMaterialParameterCollectionFunction");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
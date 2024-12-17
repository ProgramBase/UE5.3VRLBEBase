using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_GetEnumeratorNameAsString")]
	public partial class UK2Node_GetEnumeratorNameAsString : UK2Node_GetEnumeratorName, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_GetEnumeratorNameAsString");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
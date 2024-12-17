using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_GenericCreateObject")]
	public partial class UK2Node_GenericCreateObject : UK2Node_ConstructObjectFromClass, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_GenericCreateObject");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
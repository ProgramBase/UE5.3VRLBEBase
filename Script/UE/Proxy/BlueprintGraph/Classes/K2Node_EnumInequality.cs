using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_EnumInequality")]
	public partial class UK2Node_EnumInequality : UK2Node_EnumEquality, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_EnumInequality");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
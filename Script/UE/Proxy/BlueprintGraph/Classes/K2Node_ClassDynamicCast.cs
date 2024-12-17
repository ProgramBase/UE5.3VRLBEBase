using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_ClassDynamicCast")]
	public partial class UK2Node_ClassDynamicCast : UK2Node_DynamicCast, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_ClassDynamicCast");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
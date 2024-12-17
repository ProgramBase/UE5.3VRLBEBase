using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_AssignDelegate")]
	public partial class UK2Node_AssignDelegate : UK2Node_AddDelegate, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_AssignDelegate");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
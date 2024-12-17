using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_PureAssignmentStatement")]
	public partial class UK2Node_PureAssignmentStatement : UK2Node, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_PureAssignmentStatement");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
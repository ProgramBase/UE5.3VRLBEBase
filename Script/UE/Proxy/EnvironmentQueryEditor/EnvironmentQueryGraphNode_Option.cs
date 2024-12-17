using Script.CoreUObject;
using Script.Library;

namespace Script.EnvironmentQueryEditor
{
	[PathName("/Script/EnvironmentQueryEditor.EnvironmentQueryGraphNode_Option")]
	public partial class UEnvironmentQueryGraphNode_Option : UEnvironmentQueryGraphNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnvironmentQueryEditor.EnvironmentQueryGraphNode_Option");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
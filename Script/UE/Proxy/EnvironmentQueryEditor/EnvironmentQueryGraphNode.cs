using Script.CoreUObject;
using Script.AIGraph;
using Script.Library;

namespace Script.EnvironmentQueryEditor
{
	[PathName("/Script/EnvironmentQueryEditor.EnvironmentQueryGraphNode")]
	public partial class UEnvironmentQueryGraphNode : UAIGraphNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnvironmentQueryEditor.EnvironmentQueryGraphNode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
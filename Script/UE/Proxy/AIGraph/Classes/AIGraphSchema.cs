using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AIGraph
{
	[PathName("/Script/AIGraph.AIGraphSchema")]
	public partial class UAIGraphSchema : UEdGraphSchema, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIGraph.AIGraphSchema");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
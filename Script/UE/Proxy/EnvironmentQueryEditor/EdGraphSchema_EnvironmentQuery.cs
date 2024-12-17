using Script.CoreUObject;
using Script.AIGraph;
using Script.Library;

namespace Script.EnvironmentQueryEditor
{
	[PathName("/Script/EnvironmentQueryEditor.EdGraphSchema_EnvironmentQuery")]
	public partial class UEdGraphSchema_EnvironmentQuery : UAIGraphSchema, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnvironmentQueryEditor.EdGraphSchema_EnvironmentQuery");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
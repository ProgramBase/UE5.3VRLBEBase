using Script.CoreUObject;
using Script.AIGraph;
using Script.Library;

namespace Script.EnvironmentQueryEditor
{
	[PathName("/Script/EnvironmentQueryEditor.EnvironmentQueryGraph")]
	public partial class UEnvironmentQueryGraph : UAIGraph, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnvironmentQueryEditor.EnvironmentQueryGraph");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
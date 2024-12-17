using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.InterchangeEngine
{
	[PathName("/Script/InterchangeEngine.InterchangeBlueprintPipelineBase")]
	public partial class UInterchangeBlueprintPipelineBase : UBlueprint, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeEngine.InterchangeBlueprintPipelineBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
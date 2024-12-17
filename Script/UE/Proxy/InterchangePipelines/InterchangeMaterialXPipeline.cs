using Script.CoreUObject;
using Script.InterchangeCore;
using Script.Library;

namespace Script.InterchangePipelines
{
	[PathName("/Script/InterchangePipelines.InterchangeMaterialXPipeline")]
	public partial class UInterchangeMaterialXPipeline : UInterchangePipelineBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangePipelines.InterchangeMaterialXPipeline");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
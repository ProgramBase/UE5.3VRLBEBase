using Script.CoreUObject;
using Script.InterchangeCore;
using Script.Library;

namespace Script.InterchangeEditorPipelines
{
	[PathName("/Script/InterchangeEditorPipelines.InterchangeGraphInspectorPipeline")]
	public partial class UInterchangeGraphInspectorPipeline : UInterchangePipelineBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeEditorPipelines.InterchangeGraphInspectorPipeline");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
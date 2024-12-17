using Script.CoreUObject;
using Script.InterchangeEngine;
using Script.Library;

namespace Script.InterchangeEditorPipelines
{
	[PathName("/Script/InterchangeEditorPipelines.InterchangePipelineConfigurationGeneric")]
	public partial class UInterchangePipelineConfigurationGeneric : UInterchangePipelineConfigurationBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeEditorPipelines.InterchangePipelineConfigurationGeneric");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.InterchangeEditorPipelines
{
	[PathName("/Script/InterchangeEditorPipelines.InterchangePipelineBaseFactory")]
	public partial class UInterchangePipelineBaseFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeEditorPipelines.InterchangePipelineBaseFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
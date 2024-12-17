using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.InterchangeEditorPipelines
{
	[PathName("/Script/InterchangeEditorPipelines.InterchangePythonPipelineAssetFactory")]
	public partial class UInterchangePythonPipelineAssetFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeEditorPipelines.InterchangePythonPipelineAssetFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
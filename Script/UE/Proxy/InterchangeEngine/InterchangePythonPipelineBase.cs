using Script.CoreUObject;
using Script.InterchangeCore;
using Script.Library;

namespace Script.InterchangeEngine
{
	[PathName("/Script/InterchangeEngine.InterchangePythonPipelineBase")]
	public partial class UInterchangePythonPipelineBase : UInterchangePipelineBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeEngine.InterchangePythonPipelineBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
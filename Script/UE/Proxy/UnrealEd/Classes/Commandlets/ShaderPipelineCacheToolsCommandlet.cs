using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ShaderPipelineCacheToolsCommandlet")]
	public partial class UShaderPipelineCacheToolsCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ShaderPipelineCacheToolsCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.MergeShaderPipelineCachesCommandlet")]
	public partial class UMergeShaderPipelineCachesCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.MergeShaderPipelineCachesCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.HotPatcherCore
{
	[PathName("/Script/HotPatcherCore.FlibShaderCodeLibraryHelper")]
	public partial class UFlibShaderCodeLibraryHelper : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HotPatcherCore.FlibShaderCodeLibraryHelper");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
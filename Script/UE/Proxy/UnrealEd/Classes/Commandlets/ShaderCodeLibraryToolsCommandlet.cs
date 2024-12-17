using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ShaderCodeLibraryToolsCommandlet")]
	public partial class UShaderCodeLibraryToolsCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ShaderCodeLibraryToolsCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
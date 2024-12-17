using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.CompileShadersTestBedCommandlet")]
	public partial class UCompileShadersTestBedCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.CompileShadersTestBedCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.Kismet
{
	[PathName("/Script/Kismet.BlueprintCompilerExtension")]
	public partial class UBlueprintCompilerExtension : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Kismet.BlueprintCompilerExtension");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
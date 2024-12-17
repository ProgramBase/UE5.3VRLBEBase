using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealCSharpCore
{
	[PathName("/Script/UnrealCSharpCore.AssemblyLoader")]
	public partial class UAssemblyLoader : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealCSharpCore.AssemblyLoader");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
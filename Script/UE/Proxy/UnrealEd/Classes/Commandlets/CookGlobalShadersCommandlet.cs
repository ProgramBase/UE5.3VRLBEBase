using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.CookGlobalShadersCommandlet")]
	public partial class UCookGlobalShadersCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.CookGlobalShadersCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
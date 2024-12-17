using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.CookOnTheFlyServer")]
	public partial class UCookOnTheFlyServer : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.CookOnTheFlyServer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ExternalActorsCommandlet")]
	public partial class UExternalActorsCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ExternalActorsCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
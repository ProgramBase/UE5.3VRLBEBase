using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.CompositeDataTableFactory")]
	public partial class UCompositeDataTableFactory : UDataTableFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.CompositeDataTableFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
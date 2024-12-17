using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.SpecularProfileFactory")]
	public partial class USpecularProfileFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.SpecularProfileFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
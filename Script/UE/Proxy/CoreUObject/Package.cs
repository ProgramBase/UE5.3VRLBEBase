using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.Package")]
	public partial class UPackage : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.Package");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
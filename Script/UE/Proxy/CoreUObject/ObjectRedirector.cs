using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.ObjectRedirector")]
	public partial class UObjectRedirector : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.ObjectRedirector");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
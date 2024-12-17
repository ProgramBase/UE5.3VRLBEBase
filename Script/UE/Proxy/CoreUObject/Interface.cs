using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.Interface")]
	public partial class UInterface : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.Interface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/CoreUObject.Interface")]
	public interface IInterface
	{
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementCounterInterface")]
	public partial class UTypedElementCounterInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TypedElementFramework.TypedElementCounterInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/TypedElementFramework.TypedElementCounterInterface")]
	public interface ITypedElementCounterInterface : IInterface
	{
	}
}
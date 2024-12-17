using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeImport
{
	[PathName("/Script/InterchangeImport.InterchangeAnimationPayloadInterface")]
	public partial class UInterchangeAnimationPayloadInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeImport.InterchangeAnimationPayloadInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/InterchangeImport.InterchangeAnimationPayloadInterface")]
	public interface IInterchangeAnimationPayloadInterface : IInterface
	{
	}
}
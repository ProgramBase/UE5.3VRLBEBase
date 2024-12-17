using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeImport
{
	[PathName("/Script/InterchangeImport.InterchangeBlockedTexturePayloadInterface")]
	public partial class UInterchangeBlockedTexturePayloadInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeImport.InterchangeBlockedTexturePayloadInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/InterchangeImport.InterchangeBlockedTexturePayloadInterface")]
	public interface IInterchangeBlockedTexturePayloadInterface : IInterface
	{
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeImport
{
	[PathName("/Script/InterchangeImport.InterchangeSlicedTexturePayloadInterface")]
	public partial class UInterchangeSlicedTexturePayloadInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeImport.InterchangeSlicedTexturePayloadInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/InterchangeImport.InterchangeSlicedTexturePayloadInterface")]
	public interface IInterchangeSlicedTexturePayloadInterface : IInterface
	{
	}
}
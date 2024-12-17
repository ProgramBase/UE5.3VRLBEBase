using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeImport
{
	[PathName("/Script/InterchangeImport.InterchangeTextureLightProfilePayloadInterface")]
	public partial class UInterchangeTextureLightProfilePayloadInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeImport.InterchangeTextureLightProfilePayloadInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/InterchangeImport.InterchangeTextureLightProfilePayloadInterface")]
	public interface IInterchangeTextureLightProfilePayloadInterface : IInterface
	{
	}
}
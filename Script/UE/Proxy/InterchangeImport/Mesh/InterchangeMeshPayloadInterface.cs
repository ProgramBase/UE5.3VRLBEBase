using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeImport
{
	[PathName("/Script/InterchangeImport.InterchangeMeshPayloadInterface")]
	public partial class UInterchangeMeshPayloadInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeImport.InterchangeMeshPayloadInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/InterchangeImport.InterchangeMeshPayloadInterface")]
	public interface IInterchangeMeshPayloadInterface : IInterface
	{
	}
}
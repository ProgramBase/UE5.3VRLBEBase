using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundFrontend
{
	[PathName("/Script/MetasoundFrontend.MetaSoundDocumentInterface")]
	public partial class UMetaSoundDocumentInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MetasoundFrontend.MetaSoundDocumentInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/MetasoundFrontend.MetaSoundDocumentInterface")]
	public interface IMetaSoundDocumentInterface : IInterface
	{
	}
}
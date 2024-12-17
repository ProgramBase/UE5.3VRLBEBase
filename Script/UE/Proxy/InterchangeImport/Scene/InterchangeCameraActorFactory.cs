using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeImport
{
	[PathName("/Script/InterchangeImport.InterchangeCameraActorFactory")]
	public partial class UInterchangeCameraActorFactory : UInterchangeActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeImport.InterchangeCameraActorFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
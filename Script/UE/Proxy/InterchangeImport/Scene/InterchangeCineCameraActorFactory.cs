using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeImport
{
	[PathName("/Script/InterchangeImport.InterchangeCineCameraActorFactory")]
	public partial class UInterchangeCineCameraActorFactory : UInterchangeActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeImport.InterchangeCineCameraActorFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
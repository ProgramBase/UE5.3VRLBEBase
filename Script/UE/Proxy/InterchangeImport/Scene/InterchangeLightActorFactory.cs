using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeImport
{
	[PathName("/Script/InterchangeImport.InterchangeLightActorFactory")]
	public partial class UInterchangeLightActorFactory : UInterchangeActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeImport.InterchangeLightActorFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
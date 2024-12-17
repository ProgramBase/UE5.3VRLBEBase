using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeImport
{
	[PathName("/Script/InterchangeImport.InterchangeStaticMeshActorFactory")]
	public partial class UInterchangeStaticMeshActorFactory : UInterchangeActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeImport.InterchangeStaticMeshActorFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
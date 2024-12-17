using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeImport
{
	[PathName("/Script/InterchangeImport.InterchangeSkeletalMeshActorFactory")]
	public partial class UInterchangeSkeletalMeshActorFactory : UInterchangeActorFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeImport.InterchangeSkeletalMeshActorFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
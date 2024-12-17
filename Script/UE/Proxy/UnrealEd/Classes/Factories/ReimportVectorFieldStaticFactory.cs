using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ReimportVectorFieldStaticFactory")]
	public partial class UReimportVectorFieldStaticFactory : UVectorFieldStaticFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ReimportVectorFieldStaticFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
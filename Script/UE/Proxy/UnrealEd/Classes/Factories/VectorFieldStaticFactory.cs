using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.VectorFieldStaticFactory")]
	public partial class UVectorFieldStaticFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.VectorFieldStaticFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
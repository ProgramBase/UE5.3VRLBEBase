using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.CompressAnimationsCommandlet")]
	public partial class UCompressAnimationsCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.CompressAnimationsCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
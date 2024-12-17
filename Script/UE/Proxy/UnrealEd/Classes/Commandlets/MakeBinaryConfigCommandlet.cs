using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.MakeBinaryConfigCommandlet")]
	public partial class UMakeBinaryConfigCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.MakeBinaryConfigCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.DiffFilesCommandlet")]
	public partial class UDiffFilesCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.DiffFilesCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
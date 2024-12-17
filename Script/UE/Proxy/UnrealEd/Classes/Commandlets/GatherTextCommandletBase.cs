using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.GatherTextCommandletBase")]
	public partial class UGatherTextCommandletBase : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.GatherTextCommandletBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
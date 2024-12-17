using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.SequentialPartialNetBlobHandler")]
	public partial class USequentialPartialNetBlobHandler : UNetBlobHandler, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.SequentialPartialNetBlobHandler");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
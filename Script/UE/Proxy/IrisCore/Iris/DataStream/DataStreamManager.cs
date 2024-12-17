using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.DataStreamManager")]
	public partial class UDataStreamManager : UDataStream, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.DataStreamManager");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
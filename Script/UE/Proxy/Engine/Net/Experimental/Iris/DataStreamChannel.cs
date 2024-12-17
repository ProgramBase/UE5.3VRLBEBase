using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DataStreamChannel")]
	public partial class UDataStreamChannel : UChannel, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DataStreamChannel");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
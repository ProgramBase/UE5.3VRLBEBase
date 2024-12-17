using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EQSQueryResultSourceInterface")]
	public partial class UEQSQueryResultSourceInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.EQSQueryResultSourceInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/AIModule.EQSQueryResultSourceInterface")]
	public interface IEQSQueryResultSourceInterface : IInterface
	{
	}
}
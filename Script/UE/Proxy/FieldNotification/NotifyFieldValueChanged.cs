using Script.CoreUObject;
using Script.Library;

namespace Script.FieldNotification
{
	[PathName("/Script/FieldNotification.NotifyFieldValueChanged")]
	public partial class UNotifyFieldValueChanged : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FieldNotification.NotifyFieldValueChanged");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/FieldNotification.NotifyFieldValueChanged")]
	public interface INotifyFieldValueChanged : IInterface
	{
	}
}
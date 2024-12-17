using Script.CoreUObject;
using Script.Library;

namespace Script.TakesCore
{
	[PathName("/Script/TakesCore.AudioInputDeviceChannelProperty")]
	public partial class FAudioInputDeviceChannelProperty : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TakesCore.AudioInputDeviceChannelProperty");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAudioInputDeviceChannelProperty() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAudioInputDeviceChannelProperty() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAudioInputDeviceChannelProperty A, FAudioInputDeviceChannelProperty B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAudioInputDeviceChannelProperty A, FAudioInputDeviceChannelProperty B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAudioInputDeviceChannelProperty;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int AudioInputDeviceChannel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AudioInputDeviceChannel, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AudioInputDeviceChannel, __InBuffer);
				}
			}
		}

		private static uint __AudioInputDeviceChannel = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
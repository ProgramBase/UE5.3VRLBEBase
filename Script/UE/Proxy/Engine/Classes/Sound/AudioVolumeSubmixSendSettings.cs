using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AudioVolumeSubmixSendSettings")]
	public partial class FAudioVolumeSubmixSendSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AudioVolumeSubmixSendSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAudioVolumeSubmixSendSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAudioVolumeSubmixSendSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAudioVolumeSubmixSendSettings A, FAudioVolumeSubmixSendSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAudioVolumeSubmixSendSettings A, FAudioVolumeSubmixSendSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAudioVolumeSubmixSendSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EAudioVolumeLocationState ListenerLocationState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ListenerLocationState, __ReturnBuffer);

					return *(EAudioVolumeLocationState*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ListenerLocationState, __InBuffer);
				}
			}
		}

		public TArray<FSoundSubmixSendInfo> SubmixSends
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SubmixSends, __ReturnBuffer);

					return *(TArray<FSoundSubmixSendInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SubmixSends, __InBuffer);
				}
			}
		}

		private static uint __ListenerLocationState = 0;

		private static uint __SubmixSends = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.AudioMixer
{
	[PathName("/Script/AudioMixer.SwapAudioOutputResult")]
	public partial class FSwapAudioOutputResult : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AudioMixer.SwapAudioOutputResult");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSwapAudioOutputResult() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSwapAudioOutputResult() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSwapAudioOutputResult A, FSwapAudioOutputResult B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSwapAudioOutputResult A, FSwapAudioOutputResult B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSwapAudioOutputResult;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString CurrentDeviceId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CurrentDeviceId, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CurrentDeviceId, __InBuffer);
				}
			}
		}

		public FString RequestedDeviceId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RequestedDeviceId, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RequestedDeviceId, __InBuffer);
				}
			}
		}

		public ESwapAudioOutputDeviceResultState Result
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Result, __ReturnBuffer);

					return *(ESwapAudioOutputDeviceResultState*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Result, __InBuffer);
				}
			}
		}

		private static uint __CurrentDeviceId = 0;

		private static uint __RequestedDeviceId = 0;

		private static uint __Result = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
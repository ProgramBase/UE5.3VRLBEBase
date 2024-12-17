using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PlayerMuteList")]
	public partial class FPlayerMuteList : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PlayerMuteList");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPlayerMuteList() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPlayerMuteList() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPlayerMuteList A, FPlayerMuteList B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPlayerMuteList A, FPlayerMuteList B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPlayerMuteList;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bHasVoiceHandshakeCompleted
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bHasVoiceHandshakeCompleted, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bHasVoiceHandshakeCompleted, __InBuffer);
				}
			}
		}

		public int VoiceChannelIdx
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VoiceChannelIdx, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VoiceChannelIdx, __InBuffer);
				}
			}
		}

		private static uint __bHasVoiceHandshakeCompleted = 0;

		private static uint __VoiceChannelIdx = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
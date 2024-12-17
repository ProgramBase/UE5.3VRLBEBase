using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ForceFeedbackEffectOverridenChannelDetails")]
	public partial class FForceFeedbackEffectOverridenChannelDetails : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ForceFeedbackEffectOverridenChannelDetails");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FForceFeedbackEffectOverridenChannelDetails() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FForceFeedbackEffectOverridenChannelDetails() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FForceFeedbackEffectOverridenChannelDetails A, FForceFeedbackEffectOverridenChannelDetails B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FForceFeedbackEffectOverridenChannelDetails A, FForceFeedbackEffectOverridenChannelDetails B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FForceFeedbackEffectOverridenChannelDetails;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FForceFeedbackChannelDetails> ChannelDetails
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ChannelDetails, __ReturnBuffer);

					return *(TArray<FForceFeedbackChannelDetails>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ChannelDetails, __InBuffer);
				}
			}
		}

		private static uint __ChannelDetails = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
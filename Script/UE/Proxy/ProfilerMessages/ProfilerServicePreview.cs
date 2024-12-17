using Script.CoreUObject;
using Script.Library;

namespace Script.ProfilerMessages
{
	[PathName("/Script/ProfilerMessages.ProfilerServicePreview")]
	public partial class FProfilerServicePreview : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ProfilerMessages.ProfilerServicePreview");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FProfilerServicePreview() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FProfilerServicePreview() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FProfilerServicePreview A, FProfilerServicePreview B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FProfilerServicePreview A, FProfilerServicePreview B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FProfilerServicePreview;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bRequestedPreviewState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bRequestedPreviewState, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bRequestedPreviewState, __InBuffer);
				}
			}
		}

		private static uint __bRequestedPreviewState = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
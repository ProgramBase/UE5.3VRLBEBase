using Script.CoreUObject;
using Script.Library;

namespace Script.ProfilerMessages
{
	[PathName("/Script/ProfilerMessages.ProfilerServiceCapture")]
	public partial class FProfilerServiceCapture : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ProfilerMessages.ProfilerServiceCapture");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FProfilerServiceCapture() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FProfilerServiceCapture() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FProfilerServiceCapture A, FProfilerServiceCapture B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FProfilerServiceCapture A, FProfilerServiceCapture B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FProfilerServiceCapture;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bRequestedCaptureState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bRequestedCaptureState, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bRequestedCaptureState, __InBuffer);
				}
			}
		}

		private static uint __bRequestedCaptureState = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
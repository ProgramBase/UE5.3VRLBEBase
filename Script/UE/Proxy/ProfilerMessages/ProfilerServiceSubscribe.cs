using Script.CoreUObject;
using Script.Library;

namespace Script.ProfilerMessages
{
	[PathName("/Script/ProfilerMessages.ProfilerServiceSubscribe")]
	public partial class FProfilerServiceSubscribe : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ProfilerMessages.ProfilerServiceSubscribe");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FProfilerServiceSubscribe() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FProfilerServiceSubscribe() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FProfilerServiceSubscribe A, FProfilerServiceSubscribe B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FProfilerServiceSubscribe A, FProfilerServiceSubscribe B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FProfilerServiceSubscribe;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FGuid SessionId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SessionId, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SessionId, __InBuffer);
				}
			}
		}

		public FGuid InstanceId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InstanceId, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InstanceId, __InBuffer);
				}
			}
		}

		private static uint __SessionId = 0;

		private static uint __InstanceId = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
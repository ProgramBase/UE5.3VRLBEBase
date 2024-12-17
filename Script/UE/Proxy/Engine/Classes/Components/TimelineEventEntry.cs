using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.TimelineEventEntry")]
	public partial class FTimelineEventEntry : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.TimelineEventEntry");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTimelineEventEntry() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTimelineEventEntry() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTimelineEventEntry A, FTimelineEventEntry B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTimelineEventEntry A, FTimelineEventEntry B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTimelineEventEntry;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float Time
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Time, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Time, __InBuffer);
				}
			}
		}

		public FOnTimelineEvent EventFunc
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EventFunc, __ReturnBuffer);

					return *(FOnTimelineEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EventFunc, __InBuffer);
				}
			}
		}

		private static uint __Time = 0;

		private static uint __EventFunc = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
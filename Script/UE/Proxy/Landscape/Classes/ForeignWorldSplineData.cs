using Script.CoreUObject;
using Script.Library;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.ForeignWorldSplineData")]
	public partial class FForeignWorldSplineData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Landscape.ForeignWorldSplineData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FForeignWorldSplineData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FForeignWorldSplineData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FForeignWorldSplineData A, FForeignWorldSplineData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FForeignWorldSplineData A, FForeignWorldSplineData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FForeignWorldSplineData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FForeignControlPointData> ForeignControlPointData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ForeignControlPointData, __ReturnBuffer);

					return *(TArray<FForeignControlPointData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ForeignControlPointData, __InBuffer);
				}
			}
		}

		public TArray<FForeignSplineSegmentData> ForeignSplineSegmentData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ForeignSplineSegmentData, __ReturnBuffer);

					return *(TArray<FForeignSplineSegmentData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ForeignSplineSegmentData, __InBuffer);
				}
			}
		}

		private static uint __ForeignControlPointData = 0;

		private static uint __ForeignSplineSegmentData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
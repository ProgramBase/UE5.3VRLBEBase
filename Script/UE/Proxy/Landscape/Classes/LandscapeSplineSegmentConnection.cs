using Script.CoreUObject;
using Script.Library;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.LandscapeSplineSegmentConnection")]
	public partial class FLandscapeSplineSegmentConnection : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Landscape.LandscapeSplineSegmentConnection");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLandscapeSplineSegmentConnection() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLandscapeSplineSegmentConnection() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLandscapeSplineSegmentConnection A, FLandscapeSplineSegmentConnection B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLandscapeSplineSegmentConnection A, FLandscapeSplineSegmentConnection B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLandscapeSplineSegmentConnection;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ULandscapeSplineControlPoint ControlPoint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ControlPoint, __ReturnBuffer);

					return *(ULandscapeSplineControlPoint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ControlPoint, __InBuffer);
				}
			}
		}

		public float TangentLen
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TangentLen, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TangentLen, __InBuffer);
				}
			}
		}

		public FName SocketName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SocketName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SocketName, __InBuffer);
				}
			}
		}

		private static uint __ControlPoint = 0;

		private static uint __TangentLen = 0;

		private static uint __SocketName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
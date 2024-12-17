using Script.CoreUObject;
using Script.Library;

namespace Script.SlateReflector
{
	[PathName("/Script/SlateReflector.WidgetSnapshotRequest")]
	public partial class FWidgetSnapshotRequest : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SlateReflector.WidgetSnapshotRequest");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWidgetSnapshotRequest() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FWidgetSnapshotRequest() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FWidgetSnapshotRequest A, FWidgetSnapshotRequest B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWidgetSnapshotRequest A, FWidgetSnapshotRequest B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWidgetSnapshotRequest;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FGuid TargetInstanceId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TargetInstanceId, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TargetInstanceId, __InBuffer);
				}
			}
		}

		public FGuid SnapshotRequestId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SnapshotRequestId, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SnapshotRequestId, __InBuffer);
				}
			}
		}

		private static uint __TargetInstanceId = 0;

		private static uint __SnapshotRequestId = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
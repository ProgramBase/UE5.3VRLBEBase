using Script.CoreUObject;
using Script.Library;

namespace Script.SlateReflector
{
	[PathName("/Script/SlateReflector.WidgetSnapshotResponse")]
	public partial class FWidgetSnapshotResponse : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SlateReflector.WidgetSnapshotResponse");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWidgetSnapshotResponse() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FWidgetSnapshotResponse() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FWidgetSnapshotResponse A, FWidgetSnapshotResponse B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWidgetSnapshotResponse A, FWidgetSnapshotResponse B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWidgetSnapshotResponse;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

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

		public TArray<byte> SnapshotData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SnapshotData, __ReturnBuffer);

					return *(TArray<byte>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SnapshotData, __InBuffer);
				}
			}
		}

		private static uint __SnapshotRequestId = 0;

		private static uint __SnapshotData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
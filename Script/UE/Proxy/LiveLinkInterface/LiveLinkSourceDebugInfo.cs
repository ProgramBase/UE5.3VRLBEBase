using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkSourceDebugInfo")]
	public partial class FLiveLinkSourceDebugInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LiveLinkInterface.LiveLinkSourceDebugInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLiveLinkSourceDebugInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLiveLinkSourceDebugInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLiveLinkSourceDebugInfo A, FLiveLinkSourceDebugInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLiveLinkSourceDebugInfo A, FLiveLinkSourceDebugInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLiveLinkSourceDebugInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FLiveLinkSubjectName SubjectName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SubjectName, __ReturnBuffer);

					return *(FLiveLinkSubjectName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SubjectName, __InBuffer);
				}
			}
		}

		public int SnapshotIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SnapshotIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SnapshotIndex, __InBuffer);
				}
			}
		}

		public int NumberOfBufferAtSnapshot
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumberOfBufferAtSnapshot, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumberOfBufferAtSnapshot, __InBuffer);
				}
			}
		}

		private static uint __SubjectName = 0;

		private static uint __SnapshotIndex = 0;

		private static uint __NumberOfBufferAtSnapshot = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
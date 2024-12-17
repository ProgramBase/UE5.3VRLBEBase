using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.HotPatcherReleaseContext")]
	public partial class FHotPatcherReleaseContext : FHotPatcherContext, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherRuntime.HotPatcherReleaseContext");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FHotPatcherReleaseContext()
		{
		}

		public static bool operator ==(FHotPatcherReleaseContext A, FHotPatcherReleaseContext B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FHotPatcherReleaseContext A, FHotPatcherReleaseContext B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FHotPatcherReleaseContext;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FHotPatcherVersion NewReleaseVersion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NewReleaseVersion, __ReturnBuffer);

					return *(FHotPatcherVersion*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NewReleaseVersion, __InBuffer);
				}
			}
		}

		private static uint __NewReleaseVersion = 0;

	}
}
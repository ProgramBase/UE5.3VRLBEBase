using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.HotPatcherContext")]
	public partial class FHotPatcherContext : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherRuntime.HotPatcherContext");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FHotPatcherContext() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FHotPatcherContext() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FHotPatcherContext A, FHotPatcherContext B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FHotPatcherContext A, FHotPatcherContext B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FHotPatcherContext;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UScopedSlowTaskContext UnrealPakSlowTask
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UnrealPakSlowTask, __ReturnBuffer);

					return *(UScopedSlowTaskContext*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UnrealPakSlowTask, __InBuffer);
				}
			}
		}

		private static uint __UnrealPakSlowTask = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
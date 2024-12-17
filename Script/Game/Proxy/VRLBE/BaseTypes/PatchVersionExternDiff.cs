using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.PatchVersionExternDiff")]
	public partial class FPatchVersionExternDiff : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherRuntime.PatchVersionExternDiff");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPatchVersionExternDiff() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPatchVersionExternDiff() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPatchVersionExternDiff A, FPatchVersionExternDiff B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPatchVersionExternDiff A, FPatchVersionExternDiff B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPatchVersionExternDiff;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ETargetPlatform Platform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Platform, __ReturnBuffer);

					return *(ETargetPlatform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Platform, __InBuffer);
				}
			}
		}

		public TArray<FExternFileInfo> AddExternalFiles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AddExternalFiles, __ReturnBuffer);

					return *(TArray<FExternFileInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AddExternalFiles, __InBuffer);
				}
			}
		}

		public TArray<FExternFileInfo> ModifyExternalFiles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ModifyExternalFiles, __ReturnBuffer);

					return *(TArray<FExternFileInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ModifyExternalFiles, __InBuffer);
				}
			}
		}

		public TArray<FExternFileInfo> DeleteExternalFiles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DeleteExternalFiles, __ReturnBuffer);

					return *(TArray<FExternFileInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DeleteExternalFiles, __InBuffer);
				}
			}
		}

		private static uint __Platform = 0;

		private static uint __AddExternalFiles = 0;

		private static uint __ModifyExternalFiles = 0;

		private static uint __DeleteExternalFiles = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
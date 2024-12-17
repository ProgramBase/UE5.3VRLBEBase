using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.HotPatcherPatchContext")]
	public partial class FHotPatcherPatchContext : FHotPatcherContext, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherRuntime.HotPatcherPatchContext");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FHotPatcherPatchContext()
		{
		}

		public static bool operator ==(FHotPatcherPatchContext A, FHotPatcherPatchContext B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FHotPatcherPatchContext A, FHotPatcherPatchContext B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FHotPatcherPatchContext;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FHotPatcherVersion BaseVersion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BaseVersion, __ReturnBuffer);

					return *(FHotPatcherVersion*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BaseVersion, __InBuffer);
				}
			}
		}

		public FHotPatcherVersion CurrentVersion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CurrentVersion, __ReturnBuffer);

					return *(FHotPatcherVersion*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CurrentVersion, __InBuffer);
				}
			}
		}

		public FPatchVersionDiff VersionDiff
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VersionDiff, __ReturnBuffer);

					return *(FPatchVersionDiff*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VersionDiff, __InBuffer);
				}
			}
		}

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

		public FChunkInfo NewVersionChunk
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NewVersionChunk, __ReturnBuffer);

					return *(FChunkInfo*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NewVersionChunk, __InBuffer);
				}
			}
		}

		public TArray<FChunkInfo> PakChunks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PakChunks, __ReturnBuffer);

					return *(TArray<FChunkInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PakChunks, __InBuffer);
				}
			}
		}

		public TArray<FPakCommand> AdditionalFileToPak
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AdditionalFileToPak, __ReturnBuffer);

					return *(TArray<FPakCommand>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AdditionalFileToPak, __InBuffer);
				}
			}
		}

		private static uint __BaseVersion = 0;

		private static uint __CurrentVersion = 0;

		private static uint __VersionDiff = 0;

		private static uint __NewReleaseVersion = 0;

		private static uint __NewVersionChunk = 0;

		private static uint __PakChunks = 0;

		private static uint __AdditionalFileToPak = 0;

	}
}
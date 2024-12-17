using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.UpdateLevelStreamingLevelStatus")]
	public partial class FUpdateLevelStreamingLevelStatus : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.UpdateLevelStreamingLevelStatus");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FUpdateLevelStreamingLevelStatus() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FUpdateLevelStreamingLevelStatus() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FUpdateLevelStreamingLevelStatus A, FUpdateLevelStreamingLevelStatus B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FUpdateLevelStreamingLevelStatus A, FUpdateLevelStreamingLevelStatus B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FUpdateLevelStreamingLevelStatus;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName PackageName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PackageName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PackageName, __InBuffer);
				}
			}
		}

		public int LODIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LODIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LODIndex, __InBuffer);
				}
			}
		}

		public bool bNewShouldBeLoaded
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bNewShouldBeLoaded, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bNewShouldBeLoaded, __InBuffer);
				}
			}
		}

		public bool bNewShouldBeVisible
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bNewShouldBeVisible, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bNewShouldBeVisible, __InBuffer);
				}
			}
		}

		public bool bNewShouldBlockOnLoad
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bNewShouldBlockOnLoad, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bNewShouldBlockOnLoad, __InBuffer);
				}
			}
		}

		public bool bNewShouldBlockOnUnload
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bNewShouldBlockOnUnload, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bNewShouldBlockOnUnload, __InBuffer);
				}
			}
		}

		private static uint __PackageName = 0;

		private static uint __LODIndex = 0;

		private static uint __bNewShouldBeLoaded = 0;

		private static uint __bNewShouldBeVisible = 0;

		private static uint __bNewShouldBlockOnLoad = 0;

		private static uint __bNewShouldBlockOnUnload = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PropertyAccessLibrary")]
	public partial class FPropertyAccessLibrary : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PropertyAccessLibrary");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPropertyAccessLibrary() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPropertyAccessLibrary() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPropertyAccessLibrary A, FPropertyAccessLibrary B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPropertyAccessLibrary A, FPropertyAccessLibrary B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPropertyAccessLibrary;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FPropertyAccessSegment> PathSegments
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PathSegments, __ReturnBuffer);

					return *(TArray<FPropertyAccessSegment>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PathSegments, __InBuffer);
				}
			}
		}

		public TArray<FPropertyAccessPath> SrcPaths
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SrcPaths, __ReturnBuffer);

					return *(TArray<FPropertyAccessPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SrcPaths, __InBuffer);
				}
			}
		}

		public TArray<FPropertyAccessPath> DestPaths
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DestPaths, __ReturnBuffer);

					return *(TArray<FPropertyAccessPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DestPaths, __InBuffer);
				}
			}
		}

		public TArray<FPropertyAccessCopyBatch> CopyBatchArray
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CopyBatchArray, __ReturnBuffer);

					return *(TArray<FPropertyAccessCopyBatch>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CopyBatchArray, __InBuffer);
				}
			}
		}

		private static uint __PathSegments = 0;

		private static uint __SrcPaths = 0;

		private static uint __DestPaths = 0;

		private static uint __CopyBatchArray = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
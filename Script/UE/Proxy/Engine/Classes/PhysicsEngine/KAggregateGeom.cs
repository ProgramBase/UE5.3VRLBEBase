using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.KAggregateGeom")]
	public partial class FKAggregateGeom : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.KAggregateGeom");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FKAggregateGeom() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FKAggregateGeom() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FKAggregateGeom A, FKAggregateGeom B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FKAggregateGeom A, FKAggregateGeom B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FKAggregateGeom;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FKSphereElem> SphereElems
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SphereElems, __ReturnBuffer);

					return *(TArray<FKSphereElem>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SphereElems, __InBuffer);
				}
			}
		}

		public TArray<FKBoxElem> BoxElems
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoxElems, __ReturnBuffer);

					return *(TArray<FKBoxElem>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoxElems, __InBuffer);
				}
			}
		}

		public TArray<FKSphylElem> SphylElems
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SphylElems, __ReturnBuffer);

					return *(TArray<FKSphylElem>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SphylElems, __InBuffer);
				}
			}
		}

		public TArray<FKConvexElem> ConvexElems
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ConvexElems, __ReturnBuffer);

					return *(TArray<FKConvexElem>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ConvexElems, __InBuffer);
				}
			}
		}

		public TArray<FKTaperedCapsuleElem> TaperedCapsuleElems
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TaperedCapsuleElems, __ReturnBuffer);

					return *(TArray<FKTaperedCapsuleElem>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TaperedCapsuleElems, __InBuffer);
				}
			}
		}

		public TArray<FKLevelSetElem> LevelSetElems
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LevelSetElems, __ReturnBuffer);

					return *(TArray<FKLevelSetElem>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LevelSetElems, __InBuffer);
				}
			}
		}

		public TArray<FKSkinnedLevelSetElem> SkinnedLevelSetElems
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SkinnedLevelSetElems, __ReturnBuffer);

					return *(TArray<FKSkinnedLevelSetElem>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SkinnedLevelSetElems, __InBuffer);
				}
			}
		}

		private static uint __SphereElems = 0;

		private static uint __BoxElems = 0;

		private static uint __SphylElems = 0;

		private static uint __ConvexElems = 0;

		private static uint __TaperedCapsuleElems = 0;

		private static uint __LevelSetElems = 0;

		private static uint __SkinnedLevelSetElems = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
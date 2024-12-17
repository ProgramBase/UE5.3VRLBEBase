using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.ForeignSplineSegmentData")]
	public partial class FForeignSplineSegmentData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Landscape.ForeignSplineSegmentData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FForeignSplineSegmentData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FForeignSplineSegmentData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FForeignSplineSegmentData A, FForeignSplineSegmentData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FForeignSplineSegmentData A, FForeignSplineSegmentData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FForeignSplineSegmentData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FGuid ModificationKey
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ModificationKey, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ModificationKey, __InBuffer);
				}
			}
		}

		public TArray<USplineMeshComponent> MeshComponents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MeshComponents, __ReturnBuffer);

					return *(TArray<USplineMeshComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MeshComponents, __InBuffer);
				}
			}
		}

		public TLazyObjectPtr<ULandscapeSplineSegment> Identifier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Identifier, __ReturnBuffer);

					return *(TLazyObjectPtr<ULandscapeSplineSegment>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Identifier, __InBuffer);
				}
			}
		}

		private static uint __ModificationKey = 0;

		private static uint __MeshComponents = 0;

		private static uint __Identifier = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}